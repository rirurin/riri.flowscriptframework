using System.ComponentModel;
using p3rpc.flowscriptframework.dumper.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.dumper.Configuration;

public class Config : Configurable<Config>
{
    [DisplayName("Log Level")]
    [Description("Sets what logs will get printed to the Reloaded console")]
    [DefaultValue(LogLevel.Information)]
    public LogLevel LogLevel { get; set; } = LogLevel.Information;

    [DisplayName("Target Library")]
    [Description("Set the library to dump functions for")]
    [DefaultValue("Persona3Reload")]
    public string TargetLibrary { get; set; } = "Persona3Reload";
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}