using System.Runtime.InteropServices;

namespace riri.flowscriptframework.Types.V4;

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public unsafe struct MessageSection
{
    public nint* Entries;
    public long Count;
}