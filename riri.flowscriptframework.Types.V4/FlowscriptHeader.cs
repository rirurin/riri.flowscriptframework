#pragma warning disable CS1591

using System.Runtime.InteropServices;

namespace riri.flowscriptframework.Types.V4;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct FlowscriptHeader
{
    public byte FileType;
    [MarshalAs(UnmanagedType.I1)] public bool Compressed;
    public short UserId;
    public int FileSize;
    public fixed byte Magic[4];
    public int Field0C;
    public int SectionCount;
    public short LocalIntVariableCount;
    public short LocalFloatVariableCount;
    public short Endianness;
    public short Field1A;
}