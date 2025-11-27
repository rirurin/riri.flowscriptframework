using System.ComponentModel;
using RyoTune.Reloaded;
using p3rpc.flowscriptframework.Template.Configuration;

namespace p3rpc.flowscriptframework.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Log Level")]
    [DefaultValue(LogLevel.Information)]
    public LogLevel LogLevel { get; set; } = LogLevel.Information;

    [DisplayName("Enable Log Functions")]
    [DefaultValue(true)]
    public bool EnableLogFunctions { get; set; } = true;
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}