using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
    private HashSet<byte> VanillaFunctions { get; set; } = [];
    private static Dictionary<byte, Func<IMessageState, bool>> CustomFunctions = [];
    private static Dictionary<byte, string> CustomNames = [];
    private static Dictionary<byte, List<MessageParam>> CustomParams = [];
    private Queue<(string, List<MessageParam>, Func<IMessageState, bool>, ushort)> RegisterQueue = [];
    
    private static (int, int) MessageIdToParts(int Id) => (Id >> 5, Id & 0x1f);
    private static int MessageIdFromParts(int Sec, int Index) => Sec << 5 | Index;

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
    private static int CallCustomFunction(int FunctionIndex, MessageContext* Context)
    {
        var ArgCount = (FunctionIndex & 0xf00) >> 7;
        var FunctionId = (byte)(FunctionIndex & 0xff);
        var (Sec, Index) = MessageIdToParts(FunctionId);
        var MsgState = new MessageState(Context, ArgCount);
        /*
        List<string> ArgFmt = [];
        for (var i = 0; i < MsgState.ArgCount; i++)
            ArgFmt.Add(MsgState.GetArg(i).ToString());
        Log.Debug($"{nameof(MsgFramework)} || [f {Sec} {Index} {string.Join(" ", ArgFmt)}] " +
                  $"|| Context @ 0x{(nint)Context:x} || Offset 0x{Context->Offsets:x} " +
                  $"|| XYZ [ {Context->X} / {Context->Y} / {Context->Z} ]");
        if (Context->Text != null)
            Log.Debug($"\t\tContext->Text @ 0x{(nint)Context->Text:x} " +
                      $"|| {Context->Text->ToString()}");
        */
        return CustomFunctions.TryGetValue(FunctionId, out var Func)
            ? Func(MsgState) ? 1 : 0 
            : 1;
    }

    private Dictionary<byte, IHook<DebugVanillaFunction>> VanillaFunctionDebug = [];

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
            var (Sec, Index) = MessageIdToParts(FunctionId);
            Log.Debug($"{nameof(MsgFramework)} || [f {Sec} {Index} {string.Join(" ", ArgFmt)}] " +
                  $"|| Context @ 0x{(nint)Context:x} || Offset 0x{Context->Offsets:x} " +
                  $"|| XYZ [ {Context->X} / {Context->Y} / {Context->Z} ]");
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
        var (Sec, Index) = MessageIdToParts(HashValue);
        var FuncPtr = Sections[Sec].Entries[Index];
        do
        { 
            AsBytes = System.IO.Hashing.XxHash3.Hash(AsBytes);
            HashValue = AsBytes[0];
            (Sec, Index) = MessageIdToParts(HashValue);
            FuncPtr = Sections[Sec].Entries[Index];
        } while (VanillaFunctions.Contains(HashValue));
        return FuncPtr == nint.Zero;
    }
    
    public void Register(string functionName, List<MessageParam> arguments, 
        Func<IMessageState, bool> function, ushort idOverride = ushort.MaxValue)
    {
        if (Sections != null) RegisterReal(functionName, arguments, function, idOverride);
        else RegisterQueue.Enqueue((functionName, arguments, function, idOverride));
    }

    private void RegisterReal(string functionName, List<MessageParam> arguments,
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
        var (Sec, Index) = MessageIdToParts(TargetIndex);
        Log.Information($"{nameof(MsgFramework)} || Registered '{functionName}' || Args {arguments.Count} " +
                        $"|| Index 0x{TargetIndex:x} ([f {Sec} {Index}])");
        CustomFunctions.TryAdd((byte)TargetIndex, function);
        CustomNames.TryAdd((byte)TargetIndex, functionName);
        CustomParams.TryAdd((byte)TargetIndex, arguments);
        Sections[Sec].Entries[Index] = (nint)(delegate* unmanaged[Stdcall]<int, MessageContext*, int>)(&CallCustomFunction);
    }

    public List<MessageSectionJson> GetAllFunctions()
    {
        List<MessageSectionJson> Out = [];
        for (var SI = 0; SI < 8; SI++)
        {
            var Section = &Sections[SI];
            Out.Add(new(SI));
            for (var FI = 0; FI < Section->Count; FI++)
            {
                var Index = (byte)MessageIdFromParts(SI, FI);
                Out.Last().Functions.Add(new(FI, CustomNames.GetValueOrDefault(Index), 
                    Section->Entries[FI] == nint.Zero, CustomParams.GetValueOrDefault(Index)));
            }
        }
        return Out;
    }
    
    public MsgFramework(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        Project.Scans.AddScanHook("MessageFunctionTable", (ptr, _) =>
        {
            Sections = (MessageSection*)ptr;
            for (var SI = 0; SI < 8; SI++)
            {
                var Section = &Sections[SI];
                var NewCount = long.Max(0x20, Section->Count);
                // Copy vtable to allocated area
                var NewSection = NativeMemory.AllocZeroed((nuint)(NewCount * sizeof(nint)));
                if (Section->Entries != null)
                    NativeMemory.Copy(Section->Entries, NewSection, (nuint)(Section->Count * sizeof(nint)));
                Section->Entries = (nint*)NewSection;
                Section->Count = NewCount;
                for (var FI = 0; FI < Section->Count; FI++)
                {
                    if (Section->Entries[FI] == nint.Zero) continue;
                    var pFunc = (nint)_context._utils.GetAddressMayThunkAbsolute((nuint)Section->Entries[FI]);
                    var FunctionId = (byte)MessageIdFromParts(SI, FI);
                    VanillaFunctions.Add(FunctionId);
                    // This is shared between a lot of functions, copy this so we don't end up hooking all that
                    if (new Span<byte>((byte*)pFunc, 3).SequenceEqual(Constants.AlwaysReturns0))
                    {
                        var Redirected = NativeMemory.AllocZeroed(0x10);
                        fixed (byte* pAlwaysZero = Constants.AlwaysReturns0)
                            NativeMemory.Copy(pAlwaysZero, Redirected, (nuint)Constants.AlwaysReturns0.Length);
                        context._memory.ChangeProtection((nuint)Redirected, 0x10, MemoryProtection.ReadWriteExecute);
                        Section->Entries[FI] = (nint)Redirected;
                        pFunc = (nint)Redirected;
                    }
                    VanillaFunctionDebug.TryAdd(FunctionId,
                        _context._utils.MakeHooker<DebugVanillaFunction>(DebugVanillaFunctionImpl, pFunc));
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