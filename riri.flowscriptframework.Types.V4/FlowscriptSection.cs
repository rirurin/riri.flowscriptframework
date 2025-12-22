#pragma warning disable CS1591

using System.Runtime.InteropServices;

namespace riri.flowscriptframework.Types.V4;

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public unsafe struct FlowscriptSection
{
    public FlowscriptEntry* Entries;
    public long Count;
}