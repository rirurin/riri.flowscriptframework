namespace p3rpc.flowscriptframework;

public static class Constants
{
    public static readonly byte[] AlwaysReturns0 = [0x33, 0xc0, 0xc3]; // xor eax,eax; ret
    public static readonly int FlowscriptSections = 6;
}