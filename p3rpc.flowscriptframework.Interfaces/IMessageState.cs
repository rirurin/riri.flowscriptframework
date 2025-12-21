using System.Drawing;

namespace p3rpc.flowscriptframework.Interfaces;

public interface IMessageState
{
    nint Ptr { get; }
    int ArgCount { get; }
    int GetArg(int Index);

    void SetColor(Color color);
    uint GetTagLevel();
}