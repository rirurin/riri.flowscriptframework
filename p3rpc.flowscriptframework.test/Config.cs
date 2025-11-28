using System.ComponentModel;
using p3rpc.flowscriptframework.test.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.test.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Log Level")]
    [DefaultValue(LogLevel.Information)]
    public LogLevel LogLevel { get; set; } = LogLevel.Information;
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}