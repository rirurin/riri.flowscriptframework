using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Memory;
using Reloaded.Memory.SigScan.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using SharedScans.Interfaces;
using UE.Toolkit.Core.Types.Unreal.Factories;
using UE.Toolkit.Interfaces;

namespace p3rpc.flowscriptframework.test;

public class FlowscriptContext : Context
{

    public IUnrealClasses _toolkitClasses { get; init; }
    public IUnrealFactory _toolkitFactory { get; init; }
    public IUnrealState _toolkitState { get; init; }
    public IFlowFramework _flowLib { get; init; }
    
    public FlowscriptContext(long baseAddress, IConfigurable config, ILogger logger, IStartupScanner startupScanner, 
        IReloadedHooks hooks, string modLocation, Utils utils, Memory memory, ISharedScans sharedScans, 
        IUnrealClasses toolkitClasses, IUnrealFactory toolkitFactory, IUnrealState toolkitState, IFlowFramework flowLib) 
        : base(baseAddress, config, logger, startupScanner, hooks, modLocation, utils, memory, sharedScans)
    {
        _toolkitClasses = toolkitClasses;
        _toolkitFactory = toolkitFactory;
        _toolkitState = toolkitState;
        _flowLib = flowLib;
    }
}