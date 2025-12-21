using System.ComponentModel;
using RyoTune.Reloaded;
using p3rpc.flowscriptframework.Template.Configuration;

namespace p3rpc.flowscriptframework.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Log Level")]
    [DefaultValue(LogLevel.Information)]
    public LogLevel LogLevel { get; set; } = LogLevel.Information;

    [DisplayName("Enable Flowscript Log Functions")]
    [Description("Restores the Flowscript debug log functions (PUT, PUTF, PUTS, DBG_PUT and DBG_PUTS)")]
    [DefaultValue(true)]
    public bool EnableLogFunctions { get; set; } = true;
    
    [DisplayName("Log on Invoked")]
    [Description("Log when a Flowscript function is invoked")]
    [DefaultValue(false)]
    public bool LogOnFunctionInvoke { get; set; } = false;
    
    [DisplayName("Debug MessageScript Functions")]
    [Description("Print out debug information for the current MessageScript's context")]
    [DefaultValue(false)]
    public bool DebugMessageScript { get; set; } = false;
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}