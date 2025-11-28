using System.Runtime.InteropServices;

namespace p3rpc.flowscriptframework.Interfaces;

public interface IArgLifetime : IDisposable {}

public class LocalFlowInt : IArgLifetime
{
    public void Dispose() {}
}

public class LocalFlowFloat : IArgLifetime
{
    public void Dispose() {}
}

public class LocalFlowString(nint ptr) : IArgLifetime
{
    private nint Ptr = ptr;
    private bool Disposed = false;
    
    #region DISPOSE INTERFACE

    public void Dispose()
    {
        Disposing();
        GC.SuppressFinalize(this);
    }

    protected virtual void Disposing()
    {
        if (Disposed) return;
        Marshal.FreeHGlobal(Ptr);
        Disposed = true;
    }

    ~LocalFlowString() => Disposing();

    #endregion
}