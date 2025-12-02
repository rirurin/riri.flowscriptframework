namespace p3rpc.flowscriptframework.Interfaces;

public interface IMessageState
{
    nint Ptr { get; }
    int ArgCount { get; }
    int GetArg(int Index);
}