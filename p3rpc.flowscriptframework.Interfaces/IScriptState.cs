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

    public IArgLifetime PushValue(int value);
    
    public IArgLifetime PushValue(float value);
    
    public IArgLifetime PushValue(string value);
}