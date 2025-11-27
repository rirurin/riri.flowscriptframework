using System.Text;
using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Hooks.Definitions;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework;

internal interface ICommInvoke
{
    int ArgCount { get; }
    string Name { get; }
    unsafe FlowStatus Invoke(ScriptInterpreter* pWork);
}

internal record CustomFunction(string name, int argCount, Func<IScriptState, FlowStatus> function) : ICommInvoke
{
    public int ArgCount => argCount;
    public string Name => name;
    public unsafe FlowStatus Invoke(ScriptInterpreter* pWork) => function(new ScriptState(pWork));
}

internal unsafe class VanillaFunction : ICommInvoke
{
    private FlowscriptEntry* Entry;

    public VanillaFunction(FlowscriptSection* Sections, ushort CommId)
    {
        var (SecId, EntryId) = (CommId >> 0xc, CommId & 0xfff);
        Entry = &Sections[SecId].Entries[EntryId];
    }

    public string Name => Entry->GetName();

    public int ArgCount => Entry->ParamCount;

    public FlowStatus Invoke(ScriptInterpreter* pWork) => Entry->Func(pWork);
}

public unsafe class FlowFramework : ModuleBase<FlowscriptContext>, IFlowFramework
{
    private IHook<CodeFunc_COMM>? _CodeFunc_COMM;
    private delegate long CodeFunc_COMM(ScriptInterpreter* pWork);

    private int[] OriginalEnd = new int[6];
    private int[] AddStart = new int[6];

    private FlowscriptSection* Sections { get; set; }
    
    // Define these as static so ScriptState can see them
    public static int* GlobalInt { get; private set; }
    public static float* GlobalFloat { get; private set; }

    private bool FoundGlobalInt_Float = false;

    private Dictionary<ushort, CustomFunction> CustomFunctions = new();
    private Queue<(string, int, Func<IScriptState, FlowStatus>, ushort)> PreCommHookQueue = new();

    private long CodeFunc_COMMImpl(ScriptInterpreter* pWork)
    {
        if (!FoundGlobalInt_Float) return _CodeFunc_COMM!.OriginalFunction(pWork); 
        pWork->ReturnType = StackType.LocalFloat;
        var CommId = pWork->GetShortInstructionValue();
        ICommInvoke Comm = CustomFunctions.TryGetValue(CommId, out var Function)
            ? Function : new VanillaFunction(Sections, CommId);
        Log.Debug($"{nameof(FlowFramework)} || Call Function '{Comm.Name}'");
        if (Comm.Invoke(pWork) == FlowStatus.FAILURE) return 2;
        pWork->StackValueIndex -= Comm.ArgCount;
        pWork->InstructionIndex += 1;
        return 1;
    }

    private bool DoesHashCollide(ushort Id)
    {
        var (Sec, Entry) = (Id >> 0xc, Id & 0xfff);
        var VColl = Sec < 6 && Entry < AddStart[Sec];
        var CColl = CustomFunctions.ContainsKey(Id);
        return VColl || CColl;
    }

    private bool IsVanilla(ushort Id)
    {
        var (Sec, Entry) = (Id >> 0xc, Id & 0xfff);
        return Sec < 6 && Entry < OriginalEnd[Sec];
    }

    private ushort GenerateFunctionIndex(string functionName)
    {
        ushort HashValue = 0;
        var AsBytes = Encoding.UTF8.GetBytes(functionName);
        do
        {
            AsBytes = System.IO.Hashing.XxHash3.Hash(AsBytes);
            HashValue = BitConverter.ToUInt16(AsBytes, 0);
        } while (DoesHashCollide(HashValue));
        return HashValue;
    }

    public void Register(string functionName, int argCount, Func<IScriptState, FlowStatus> function, 
        ushort idOverride = ushort.MaxValue)
    {
        if (_CodeFunc_COMM != null) RegisterReal(functionName, argCount, function, idOverride);
        else PreCommHookQueue.Enqueue((functionName, argCount, function, idOverride));
    }

    private void RegisterReal(string functionName, int argCount, Func<IScriptState, FlowStatus> function,
        ushort idOverride = ushort.MaxValue)
    {
        var TargetIndex = IsVanilla(idOverride) ? idOverride : GenerateFunctionIndex(functionName);
        Log.Information($"{nameof(FlowFramework)} || Registered '{functionName}' || Args {argCount} || Index 0x{TargetIndex:x}");
        CustomFunctions.TryAdd(TargetIndex, new CustomFunction(functionName, argCount, function));
    }
    
    // Available hashes: u16::MAX - 0x374 = 0xfc8b (64651 functions)
    public FlowFramework(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        Project.Scans.AddScanHook(nameof(CodeFunc_COMM), (ptr, hooks) =>
        {
            Sections = (FlowscriptSection*)Utilities.GetGlobalAddress((int*)(ptr + 0x54 + 0x3));
            for (var SI = 0; SI < 6; SI++)
            {
                var Section = &Sections[SI];
                // For new titles that may get DLC/expansions in the future, add some offset to this
                // P3RE already had Ep Aigis so we don't care
                Log.Debug($"{Section->Count}");
                OriginalEnd[SI] = (int)Section->Count;
                AddStart[SI] = (int)Section->Count;
            }
            // Now that we know where the bounds are for vanilla values, process queued elements
            while (PreCommHookQueue.TryDequeue(out var Queued))
                RegisterReal(Queued.Item1, Queued.Item2, Queued.Item3, Queued.Item4);
            _CodeFunc_COMM = hooks.CreateHook<CodeFunc_COMM>(CodeFunc_COMMImpl, ptr).Activate();
        });
        Project.Scans.AddScanHook("GlobalInt_Float", (ptr, _) =>
        {
            var pGlobalFloat = _context._baseAddress + *(int*)(ptr + 6);
            var pGlobalInt = _context._baseAddress + *(int*)(ptr + 0x15);
            Log.Debug($"{nameof(FlowFramework)} || Set global int list to 0x{pGlobalInt:x}");
            Log.Debug($"{nameof(FlowFramework)} || Set global float list to 0x{pGlobalFloat:x}");
            GlobalInt = (int*)pGlobalInt;
            GlobalFloat = (float*)pGlobalFloat;

            FoundGlobalInt_Float = true;
        });
    }

    public override void Register() {}
}