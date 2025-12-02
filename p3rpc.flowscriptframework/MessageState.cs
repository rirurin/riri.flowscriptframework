using p3rpc.flowscriptframework.Interfaces;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework;

public unsafe class MessageState(MessageContext* context, int argCount) : IMessageState
{
    private MessageContext* Context { get; } = context;
    public nint Ptr => (nint)Context;
    public int ArgCount => (argCount - 2) / 2;

    public int GetArg(int Index)
    {
        if (Index >= ArgCount)
        {
            throw new Exception(
                $"{nameof(MessageState)} || Tried to access argument {Index}, but argument length is {ArgCount}");
        }
        // Context->Offsets will point to the first argument
        var Args = (byte*)(Context->Msg + Context->Offsets) + Index * 2;
        return ((byte)(Args[1] - 1) << 8) | (byte)(Args[0] - 1);
    }
}