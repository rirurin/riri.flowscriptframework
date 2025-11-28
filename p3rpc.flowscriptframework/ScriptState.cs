using System.Runtime.InteropServices;
using p3rpc.flowscriptframework.Interfaces;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework;

public unsafe class ScriptState(ScriptInterpreter* context) : IScriptState
{
    private ScriptInterpreter* Context { get; } = context;
    
    // Original function: GetIntArg @ 0x14bd14f50 (P3R 1.0.0 Steam)
    public int GetIntArg(int index)
    {
        var Param = Context->StackValueIndex - index - 1;
        if (Param > 0x2f) return 0;
        return Context->GetStackType(Param) switch
        {
            StackType.Int or StackType.String => Context->GetIntValue(Param),
            StackType.Float => (int)Context->GetFloatValue(Param),
            StackType.GlobalInt => FlowFramework.GlobalInt[Context->GetIntValue(Param)],
            StackType.GlobalFloat => (int)FlowFramework.GlobalFloat[Context->GetIntValue(Param)],
            _ => 0
        };
    }
    
    // Original function: GetFloatArg @ 0x14bd14020 (P3R 1.0.0 Steam)
    public float GetFloatArg(int index)
    {
        var Param = Context->StackValueIndex - index - 1;
        if (Param > 0x2f) return 0;
        return Context->GetStackType(Param) switch
        {
            StackType.Int or StackType.String => Context->GetIntValue(Param),
            StackType.Float => Context->GetFloatValue(Param),
            StackType.GlobalInt => FlowFramework.GlobalInt[Context->GetIntValue(Param)],
            StackType.GlobalFloat => FlowFramework.GlobalFloat[Context->GetIntValue(Param)],
            _ => 0
        };
    }

    // Original function: GetStringArg @ 0x14122f410 (P3R 1.0.0 Steam)
    public string? GetStringArg(int index)
    {
        var Param = Context->StackValueIndex - index - 1;
        return Context->GetStackType(Param) == StackType.LocalInt
            ? Marshal.PtrToStringUTF8((nint)Context->GetStringValue(Param))
            : null;
    }

    public void SetReturnValue(int value)
    {
        Context->IntReturnValue = value;
        Context->ReturnType = StackType.Int;
    }

    public void SetReturnValue(float value)
    {
        Context->FloatReturnValue = value;
        Context->ReturnType = StackType.Float;
    }
    
    // Original function: OPCODE_PUSHIS @ 0x14121a220 (P3R 1.0.0 Steam)
    public IArgLifetime PushValue(int value)
    {
        Context->SetStackType(Context->StackValueIndex, StackType.Int);
        var Value = Context->SetIntValue(Context->StackValueIndex, value);
        Context->StackValueIndex++;
        return Value;
    }

    // Original function: OPCODE_PUSHF @ 0x14121a220 (P3R 1.0.0 Steam)
    public IArgLifetime PushValue(float value)
    {
        Context->SetStackType(Context->StackValueIndex, StackType.Float);
        var Value = Context->SetFloatValue(Context->StackValueIndex, value);
        Context->StackValueIndex++;
        return Value;
    }

    // Original function: OPCODE_PUSHSTR @ 0x14121a220 (P3R 1.0.0 Steam)
    public IArgLifetime PushValue(string value)
    {
        Context->SetStackType(Context->StackValueIndex, StackType.LocalInt);
        var Value = Context->SetStringValue(Context->StackValueIndex, value);
        Context->StackValueIndex++;
        return Value;
    }
}