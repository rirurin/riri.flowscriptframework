#pragma warning disable CS1591

using riri.flowscriptframework.Types.V4;

namespace p3rpc.flowscriptframework.Interfaces;

public interface IScriptState
{
    
    /// <summary>
    /// Gets an integer argument at a given index.
    /// </summary>
    /// <param name="index">Argument index.</param>
    /// <returns>The integer argument.</returns>
    public int GetIntArg(int index);

    /// <summary>
    /// Gets a float argument at a given index.
    /// </summary>
    /// <param name="index">Argument index.</param>
    /// <returns>The float argument.</returns>
    public float GetFloatArg(int index);

    /// <summary>
    /// Gets a string argument at a given index.
    /// </summary>
    /// <param name="index">Argument index.</param>
    /// <returns>The string argument.</returns>
    public string? GetStringArg(int index);

    /// <summary>
    /// Sets the functions return value.
    /// </summary>
    /// <param name="value">A integer value for the return value.</param>
    public void SetReturnValue(int value);

    /// <summary>
    /// Sets the functions return value.
    /// </summary>
    /// <param name="value">A float value for the return value.</param>
    public void SetReturnValue(float value);

    /// <summary>
    /// Gets the return value, assuming it's an integer
    /// </summary>
    /// <returns>The integer return value</returns>
    public int GetIntReturnValue();
   
    /// <summary>
    /// Gets the return value, assuming it's a float
    /// </summary>
    /// <returns>The float return value</returns>
    public float GetFloatReturnValue();

    /// <summary>
    /// Pushes an integer value onto the interpreter's stack.
    /// </summary>
    /// <param name="value">Value to push onto the stack</param>
    /// <returns>An object that maintains the lifetime of the object. Not relevant for integers.</returns>
    public IArgLifetime PushValue(int value);
    
    /// <summary>
    /// Pushes an float value onto the interpreter's stack.
    /// </summary>
    /// <param name="value">Value to push onto the stack</param>
    /// <returns>An object that maintains the lifetime of the object. Not relevant for floats.</returns>   
    public IArgLifetime PushValue(float value);
    
    /// <summary>
    /// Pushes a string onto the interpreter's stack.
    /// </summary>
    /// <param name="value">Value to push onto the stack</param>
    /// <returns>An object that maintains the lifetime of the object. This is relevant for strings since the string will
    /// get deallocated at the end of the variable's scope. This must stay in scope for at least as long as the
    /// function call.</returns>
    public IArgLifetime PushValue(string value);

    /// <summary>
    /// For functions that are overriding an existing one, this allows the user to call the original function.
    /// </summary>
    /// <returns>The flow status of the original function call. For new functions, this will always return FlowStatus.FAILURE.</returns>
    public FlowStatus OriginalFunction();
}