using System.Diagnostics;
using System.Text;
using AtlusScriptLibrary.Common.Libraries;
using AtlusScriptLibrary.Common.Text.Encodings;
using p3rpc.commonmodutils;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using p3rpc.flowscriptframework.dumper.Template;
using p3rpc.flowscriptframework.dumper.Configuration;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Memory;
using Reloaded.Memory.SigScan.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using RyoTune.Reloaded;
using SharedScans.Interfaces;

namespace p3rpc.flowscriptframework.dumper;

public class Mod : ModBase
{
    private readonly IModLoader _modLoader;
    private readonly IReloadedHooks? _hooks;
    private readonly ILogger _logger;
    private readonly IMod _owner;
    private Config _configuration;
    private readonly IModConfig _modConfig;

    private DumperContext _context;
    private readonly ModuleRuntime<DumperContext> _runtime;

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
        if (_hooks == null) throw new Exception($"[{_modConfig.ModName}] Reference to Reloaded Hooks in ModConfig is missing!");
        var baseAddress = process.MainModule.BaseAddress;
        var startupScanner = Utils.GetDependency<IStartupScanner>(_modLoader, _modConfig.ModName, "Reloaded Startup Scanner");
        var utils = Utils.Create(_modLoader, startupScanner, _logger, _hooks, baseAddress, _modConfig.ModName, System.Drawing.Color.PaleTurquoise);
        
        var sharedScans = utils.GetDependencyEx<ISharedScans>("Shared Scans");
        var flowLib = utils.GetDependencyEx<IFlowFramework>("Flowscript Library");
        var msgLib = utils.GetDependencyEx<IMsgFramework>("Messagescript Library");
        
        LibraryLookup.SetLibraryPath($"{_modLoader.GetDirectoryForModId(_modConfig.ModId)}/Libraries");
        AtlusEncoding.SetCharsetDirectory($"{_modLoader.GetDirectoryForModId(_modConfig.ModId)}/Charsets");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        
        _context = new(
            baseAddress, _configuration, _logger, startupScanner, _hooks, _modLoader.GetDirectoryForModId(_modConfig.ModId), 
            utils, new Memory(), sharedScans, flowLib, msgLib);
        _runtime = new(_context);
        _runtime.AddModule<Dumper>();
        _runtime.RegisterModules();
        
        _modLoader.OnModLoaderInitialized += OnLoaderInit;
        _modLoader.ModLoading += OnModLoading;
    }

    #region Standard Overrides

    public override void ConfigurationUpdated(Config configuration)
    {
        _configuration = configuration;
        _runtime.UpdateConfiguration(_configuration);
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