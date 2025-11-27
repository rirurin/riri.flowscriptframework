using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace riri.flowscriptframework.Types.V4;

[StructLayout(LayoutKind.Explicit, Size = 0x270)]
public unsafe struct ScriptInterpreter
{
    [FieldOffset(0x0)] public fixed char ProcedureName[48];
    [FieldOffset(0x30)] public int InstructionIndex;
    [FieldOffset(0x34)] public int StackValueIndex;
    [FieldOffset(0x38)] private fixed byte StackType[48];
    [FieldOffset(0x68)] private fixed long StackValue[48]; // should be nint but that can't be used for a fixed buffer
    [FieldOffset(0x1e8)] public FlowscriptHeader* FlowHeader;
    [FieldOffset(0x1f0)] public nint SegmentTable;
    [FieldOffset(0x1f8)] public nint ProcedureLabels;
    [FieldOffset(0x200)] public nint JumpLabels;
    [FieldOffset(0x208)] public ushort* Instructions;
    [FieldOffset(0x210)] public nint MessageHeader;
    [FieldOffset(0x218)] public nint StringTable;
    [FieldOffset(0x220)] public int ProcIndex1;
    [FieldOffset(0x224)] public int ProcIndex2;
    [FieldOffset(0x228)] public int ScriptTimer;
    [FieldOffset(0x22c)] public int CommandTimer;
    [FieldOffset(0x230)] public int UserTimer;
    [FieldOffset(0x238)] public nint MemHandle;
    [FieldOffset(0x240)] public int* LocalIntVariables;
    [FieldOffset(0x248)] public float* LocalFloatVariables;
    [FieldOffset(0x250)] public ScriptInterpreter* Prev;
    [FieldOffset(0x258)] public ScriptInterpreter* Next;
    [FieldOffset(0x260)] public nint UserData;
    [FieldOffset(0x268)] public nint UserDataEx;

    public ushort GetShortInstructionOpcode() => GetShortInstruction(InstructionIndex * 2);
    public ushort GetShortInstructionValue() => GetShortInstruction(InstructionIndex * 2 + 1);

    private ushort GetShortInstruction(int Index)
    {
        var Value = Instructions[Index];
        return (FlowHeader->Endianness & 1) != 0 ? BinaryPrimitives.ReverseEndianness(Value) : Value;
    }
    
    public StackType GetStackType(int Index)
    {
        if (Index > 46) throw new Exception($"Attempted to access out of bounds stack value type {Index}");
        fixed (byte* pStackType = StackType) { return *(StackType*)(pStackType + Index); }
    }

    public StackType ReturnType
    {
        get => (StackType)StackType[47];
        set => StackType[47] = (byte)value;
    }

    public int GetIntValue(int Index)
    {
        if (Index > 46) throw new Exception($"Attempted to access out of bounds stack value type {Index}");
        fixed (long* pStackValue = StackValue) { return *(int*)(pStackValue + Index); }
    }

    public float GetFloatValue(int Index)
    {
        if (Index > 46) throw new Exception($"Attempted to access out of bounds stack value type {Index}");
        fixed (long* pStackValue = StackValue) { return *(float*)(pStackValue + Index); }       
    }
    
    public char* GetStringValue(int Index)
    {
        
        if (Index > 46) throw new Exception($"Attempted to access out of bounds stack value type {Index}");
        fixed (long* pStackValue = StackValue) { return *(char**)(pStackValue + Index); }       
    }

    public int IntReturnValue
    {
        get => (int)StackValue[47];
        set => StackValue[47] = value;
    }
    
    public float FloatReturnValue
    {
        get => BitConverter.Int32BitsToSingle((int)StackValue[47]);
        set => StackValue[47] = BitConverter.SingleToInt32Bits(value);
    }
}