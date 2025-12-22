#pragma warning disable CS1591

using riri.flowscriptframework.Types.V4;

namespace p3rpc.flowscriptframework.Interfaces;

public interface IInvokeParams
{
    IArgLifetime Push(IScriptState ctx);
}

public record IntParam(int Value) : IInvokeParams
{
    public IArgLifetime Push(IScriptState ctx) => ctx.PushValue(Value);
}

public record FloatParam(float Value) : IInvokeParams
{
    public IArgLifetime Push(IScriptState ctx) => ctx.PushValue(Value);
}

public record StringParam(string Value) : IInvokeParams
{
    public IArgLifetime Push(IScriptState ctx) => ctx.PushValue(Value);
}