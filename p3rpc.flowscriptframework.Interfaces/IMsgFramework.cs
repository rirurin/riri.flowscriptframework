using riri.flowscriptframework.Types.V4;

namespace p3rpc.flowscriptframework.Interfaces;

public interface IMsgFramework
{
    /// <summary>
    /// Registers a method as a MessageScript function.
    /// </summary>
    /// <param name="functionName">The name of the function.</param>
    /// <param name="arguments">The list of arguments that the function uses.</param>
    /// <param name="function">The contents of the custom functions.</param>
    /// <param name="idOverride">Optional value to override vanilla message functions only.</param>
    public void Register(string functionName, List<MessageParam> arguments,
        Func<IMessageState, bool> function, ushort idOverride = ushort.MaxValue);

    public List<MessageSectionJson> GetAllFunctions();
}