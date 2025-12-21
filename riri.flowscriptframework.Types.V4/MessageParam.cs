namespace riri.flowscriptframework.Types.V4;

public class MessageParam(string? name = null, string? desc = null)
{
    public string? Name { get; } = name;
    public string? Desc { get; } = desc;
}