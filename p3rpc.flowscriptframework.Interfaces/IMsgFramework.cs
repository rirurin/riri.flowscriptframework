namespace p3rpc.flowscriptframework.Interfaces;

public interface IMsgFramework
{
    /// <summary>
    /// Registers a method as a MessageScript function.
    /// </summary>
    /// <param name="functionName">The name of the function.</param>
    /// <param name="argCount">The number of args that the funciton uses.</param>
    /// <param name="function">The contents of the custom functions.</param>
    /// <param name="idOverride">Optional value to override vanilla message functions only.</param>
    public void Register(string functionName, int argCount,
        Func<IMessageState, bool> function, ushort idOverride = ushort.MaxValue);
}