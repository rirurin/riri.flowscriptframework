namespace p3rpc.flowscriptframework.Interfaces;

public interface IFlowFramework
{
    /// <summary>
    /// Registers a method as a flowscript function.
    /// </summary>
    /// <typeparam name="TFunction">A delegate with the desired method assigned to it.</typeparam>
    /// <param name="functionName">The name of the function</param>
    /// <param name="argCount">The number of args the function uses.</param>
    /// <param name="function">The contents of the custom functions.</param>
    /// <param name="idOverride">Optional value to override vanilla flow functions only.</param>
    public void Register(string functionName, int argCount, Func<IScriptState, FlowStatus> function, ushort idOverride = ushort.MaxValue);
}