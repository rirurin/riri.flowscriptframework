using p3rpc.commonmodutils;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Memory;
using Reloaded.Memory.SigScan.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using SharedScans.Interfaces;

namespace p3rpc.flowscriptframework;

public class FlowscriptContext : Context
{
    public FlowscriptContext(long baseAddress, IConfigurable config, ILogger logger, IStartupScanner startupScanner, IReloadedHooks hooks, string modLocation, Utils utils, Memory memory, ISharedScans sharedScans) 
        : base(baseAddress, config, logger, startupScanner, hooks, modLocation, utils, memory, sharedScans)
    {
    }
}