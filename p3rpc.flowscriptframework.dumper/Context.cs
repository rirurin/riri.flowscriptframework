using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Memory;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Memory.SigScan.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using SharedScans.Interfaces;

namespace p3rpc.flowscriptframework.dumper;

public class DumperContext : Context
{

    public IFlowFramework _flowLib { get; init; }
    public IMsgFramework _msgLib { get; init; }
    
    public DumperContext(long baseAddress, IConfigurable config, ILogger logger, IStartupScanner startupScanner, 
        IReloadedHooks hooks, string modLocation, Utils utils, Memory memory, ISharedScans sharedScans, 
        IFlowFramework flowLib, IMsgFramework msgLib) 
        : base(baseAddress, config, logger, startupScanner, hooks, modLocation, utils, memory, sharedScans)
    {
        _flowLib = flowLib;
        _msgLib = msgLib;
    }
}