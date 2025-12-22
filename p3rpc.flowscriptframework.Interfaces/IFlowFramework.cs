#pragma warning disable CS1591

using riri.flowscriptframework.Types.V4;

namespace p3rpc.flowscriptframework.Interfaces;

public interface IFlowFramework
{
    /// <summary>
    /// Registers a method as a flowscript function.
    /// </summary>
    /// <param name="functionName">The name of the function</param>
    /// <param name="args">The data type of each argument passed into the function.</param>
    /// <param name="returnArg">The data type of the return value</param>
    /// <param name="function">The contents of the custom functions.</param>
    /// <param name="idOverride">Optional value to override vanilla flow functions only.</param>
    public void Register(string functionName, ParamType[] args, ParamType returnArg,
        Func<IScriptState, FlowStatus> function, ushort idOverride = ushort.MaxValue);

    public bool TryGetFunctionIndex(string Name, out ushort Index);

    public void InvokeVoid(string Name, List<IInvokeParams> Args);

    public int InvokeInt(string Name, List<IInvokeParams> Args);
    
    public float InvokeFloat(string Name, List<IInvokeParams> Args);

    public List<FlowscriptJson> GetAllFunctions();

    public List<int> GetVanillaSectionEnds();
}