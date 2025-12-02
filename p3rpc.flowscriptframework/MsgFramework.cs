using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using NCalc.Domain;
using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Configuration;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Hooks.Definitions;
using Reloaded.Memory.Enums;
using Reloaded.Memory.Interfaces;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework;

public unsafe class MsgFramework : ModuleBase<FlowscriptContext>, IMsgFramework
{
    
    private MessageSection* Sections { get; set; }
    private HashSet<byte> VanillaFunctions { get; set; } = new();
    private static Dictionary<byte, Func<IMessageState, bool>> CustomFunctions = new();
    private Queue<(string, int, Func<IMessageState, bool>, ushort)> RegisterQueue = new();

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
    private static int CallCustomFunction(int FunctionIndex, MessageContext* Context)
         => CustomFunctions.TryGetValue((byte)(FunctionIndex & 0xff), out var Func)
            ? Func(new MessageState(Context, (FunctionIndex & 0xf00) >> 7)) ? 1 : 0 : 1;

    private Dictionary<byte, IHook<DebugVanillaFunction>> VanillaFunctionDebug = new();

    private delegate int DebugVanillaFunction(int FunctionIndex, MessageContext* Context);

    private int DebugVanillaFunctionImpl(int FunctionIndex, MessageContext* Context)
    {
        var FunctionId = (byte)(FunctionIndex & 0xff);
        var MsgState = new MessageState(Context, (FunctionIndex & 0xf00) >> 7);
        if (((Config)_context._config).DebugMessageScript)
        {
            List<string> ArgFmt = [];
            for (var i = 0; i < MsgState.ArgCount; i++)
                ArgFmt.Add(MsgState.GetArg(i).ToString());
            Log.Debug($"{nameof(MsgFramework)} || [f {FunctionId >> 5} {FunctionId & 0x1f} {string.Join(" ", ArgFmt)}] " +
                      $"|| Context @ 0x{(nint)Context:x} || XYZ [ {Context->X} / {Context->Y} /  {Context->Z} ]");
            if (Context->Text != null)
                Log.Debug($"\t\tContext->Text @ 0x{(nint)Context->Text:x} " +
                          $"|| {Context->Text->ToString()}");           
        }
        return VanillaFunctionDebug.TryGetValue(FunctionId, out var Original)
            ? Original.OriginalFunction(FunctionIndex, Context) : 0;
    }

    private bool GenerateFunctionIndex(string functionName, out byte HashValue)
    {
        var AsBytes = Encoding.UTF8.GetBytes(functionName);
        AsBytes = System.IO.Hashing.XxHash3.Hash(AsBytes);
        HashValue = AsBytes[0];
        var StartHash = HashValue;
        var FuncPtr = Sections[HashValue >> 5].Entries[HashValue & 0x1f];
        do
        { 
            AsBytes = System.IO.Hashing.XxHash3.Hash(AsBytes);
            HashValue = AsBytes[0];
            FuncPtr = Sections[HashValue >> 5].Entries[HashValue & 0x1f];
        } while (VanillaFunctions.Contains(HashValue));
        return FuncPtr != null;
    }
    
    public void Register(string functionName, int argCount, 
        Func<IMessageState, bool> function, ushort idOverride = ushort.MaxValue)
    {
        if (Sections != null) RegisterReal(functionName, argCount, function, idOverride);
        else RegisterQueue.Enqueue((functionName, argCount, function, idOverride));
    }

    private void RegisterReal(string functionName, int argCount,
        Func<IMessageState, bool> function, ushort idOverride = ushort.MaxValue)
    {
        var TargetIndex = VanillaFunctions.Contains((byte)idOverride) ? idOverride : ushort.MaxValue;
        if (TargetIndex == ushort.MaxValue)
        {
            if (!GenerateFunctionIndex(functionName, out var BTargetIndex))
            {
                Log.Warning($"{nameof(MsgFramework)} || Cannot add '{functionName}' due to a naming conflict. Please rename this!");
                return;   
            }

            TargetIndex = BTargetIndex;
        }
        
        Log.Information($"{nameof(MsgFramework)} || Registered '{functionName}' || Args {argCount} || Index 0x{TargetIndex:x}");
        CustomFunctions.TryAdd((byte)TargetIndex, function);
    }
    
    public MsgFramework(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        Project.Scans.AddScanHook("MessageFunctionTable", (ptr, _) =>
        {
            Sections = (MessageSection*)ptr;
            for (var SI = 0; SI < 8; SI++)
            {
                var Section = &Sections[SI];
                var NewSection = NativeMemory.AllocZeroed((nuint)(long.Max(0x20, Section->Count) * sizeof(nint)));
                NativeMemory.Copy(Section, NewSection, (nuint)(Section->Count * sizeof(nint)));
                for (var FI = 0; FI < Section->Count; FI++)
                {
                    if (Section->Entries[FI] != nint.Zero)
                    {
                        var FunctionId = (byte)((SI << 0x5) | FI);
                        VanillaFunctions.Add(FunctionId);
                        // This is shared between a lot of functions, copy this so we don't end up hooking all that
                        if (new Span<byte>((byte*)Section->Entries[FI], 3).SequenceEqual(Constants.AlwaysReturns0))
                        {
                            var Redirected = NativeMemory.AllocZeroed(0x10);
                            fixed (byte* pAlwaysZero = Constants.AlwaysReturns0)
                            {
                                NativeMemory.Copy(pAlwaysZero, Redirected, (nuint)Constants.AlwaysReturns0.Length);
                            }
                            context._memory.ChangeProtection((nuint)Section->Entries[FI], 0x10, MemoryProtection.ReadWriteExecute);
                            Section->Entries[FI] = (nint)Redirected;
                        }
                        // Log.Debug($"FunctionDebug: Add {FunctionId} at 0x{Section->Entries[FI]:x}");
                        VanillaFunctionDebug.TryAdd(FunctionId,
                            _context._utils.MakeHooker<DebugVanillaFunction>(DebugVanillaFunctionImpl, Section->Entries[FI]));
                    }   
                }
            }
            while (RegisterQueue.TryDequeue(out var Queued))
                RegisterReal(Queued.Item1, Queued.Item2, Queued.Item3, Queued.Item4);
        });
    }

    public override void Register()
    {
    }
}