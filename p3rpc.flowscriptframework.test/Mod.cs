using System.Diagnostics;
using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using p3rpc.flowscriptframework.test.Template;
using p3rpc.flowscriptframework.test.Configuration;
using Reloaded.Memory;
using Reloaded.Memory.SigScan.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using RyoTune.Reloaded;
using SharedScans.Interfaces;
using UE.Toolkit.Core.Types.Unreal.Factories;
using UE.Toolkit.Interfaces;

namespace p3rpc.flowscriptframework.test;

public class Mod : ModBase
{
    private readonly IModLoader _modLoader;
    private readonly IReloadedHooks? _hooks;
    private readonly ILogger _logger;
    private readonly IMod _owner;
    private Config _configuration;
    private readonly IModConfig _modConfig;
    
    private FlowscriptContext _context;
    private readonly ModuleRuntime<FlowscriptContext> _runtime;

    public Mod(ModContext context)
    {
        _modLoader = context.ModLoader;
        _hooks = context.Hooks;
        _logger = context.Logger;
        _owner = context.Owner;
        _configuration = context.Configuration;
        _modConfig = context.ModConfig;
        
#if DEBUG
        //Debugger.Launch();
#endif
        Project.Initialize(_modConfig, _modLoader, _logger);
        Log.LogLevel = _configuration.LogLevel;
        
        var process = Process.GetCurrentProcess();
        if (process?.MainModule == null) throw new Exception($"[{_modConfig.ModName}] Process is null");
        var baseAddress = process.MainModule.BaseAddress;
        var startupScanner = Utils.GetDependency<IStartupScanner>(_modLoader, _modConfig.ModName, "Reloaded Startup Scanner");
        Utils utils = Utils.Create(_modLoader, startupScanner, _logger, _hooks, baseAddress, _modConfig.ModName, System.Drawing.Color.PaleTurquoise);
        
        var sharedScans = utils.GetDependencyEx<ISharedScans>("Shared Scans");
        var toolkitClasses = utils.GetDependencyEx<IUnrealClasses>("Class Interface (UE Toolkit");
        var toolkitFactory = utils.GetDependencyEx<IUnrealFactory>("Factory Interface (UE Toolkit)");
        var toolkitState = utils.GetDependencyEx<IUnrealState>("State Interface (UE Toolkit)");
        var flowLib = utils.GetDependencyEx<IFlowFramework>("Flowscript Library");
        
        _context = new(
            baseAddress, _configuration, _logger, startupScanner, _hooks, _modLoader.GetDirectoryForModId(_modConfig.ModId), 
            utils, new Memory(), sharedScans, toolkitClasses, toolkitFactory, toolkitState, flowLib);
        _runtime = new(_context);
        _runtime.AddModule<Invoke>();
        _runtime.AddModule<Registration>();
        _runtime.RegisterModules();
        
        _modLoader.OnModLoaderInitialized += OnLoaderInit;
        _modLoader.ModLoading += OnModLoading;
    }

    #region Standard Overrides

    public override void ConfigurationUpdated(Config configuration)
    {
        _configuration = configuration;
    }

    #endregion
    
    private void OnLoaderInit()
    {
        _modLoader.OnModLoaderInitialized -= OnLoaderInit;
        _modLoader.ModLoading -= OnModLoading;
    }

    private void OnModLoading(IModV1 mod, IModConfigV1 conf)
    {
    }

    #region For Exports, Serialization etc.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Mod()
    {
    }
#pragma warning restore CS8618

    #endregion
}