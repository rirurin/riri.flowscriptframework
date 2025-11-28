using System.Runtime.InteropServices;

namespace p3rpc.flowscriptframework.test;

public static class Native
{
    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern nint GetModuleHandleA(string lpModuleName);
    
    [DllImport("user32.dll")]
    public static extern ushort GetAsyncKeyState(int vKey);
}
