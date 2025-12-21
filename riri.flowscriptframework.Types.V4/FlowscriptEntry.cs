using System.Runtime.InteropServices;

namespace riri.flowscriptframework.Types.V4;

[StructLayout(LayoutKind.Sequential, Size = 0x40)]
public unsafe struct FlowscriptEntry
{
    public delegate* unmanaged[Stdcall]<ScriptInterpreter*, FlowStatus> Func;
    public int ParamCount;
    public ParamType ReturnType;
    private char* Name;
    private fixed int ParamTypes[10];

    public string GetName() => Marshal.PtrToStringAnsi((nint)Name)!;

    public ParamType GetParamType(int Index)
    {
        if (Index >= 10) throw new Exception($"{nameof(FlowscriptEntry)} || Parameter index {Index} out of range");
        return (ParamType)ParamTypes[Index];
    }

    public ParamType[] GetParamList()
    {
        var Types = new ParamType[ParamCount];
        for (var i = 0; i < ParamCount; i++)
            Types[i] = GetParamType(i);
        return Types;
    }

    public override string ToString()
        => $"{ReturnType} {GetName()}({string.Join(", ", GetParamList().Select(x => $"{x}"))})";
}