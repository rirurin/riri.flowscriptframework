#pragma warning disable CS1591

namespace riri.flowscriptframework.Types.V4;

public class MessageSectionJson(int index)
{
    public int Index { get; } = index;
    public List<MessageFunctionJson> Functions { get; } = [];
}

public class MessageFunctionJson(int index, string? name, bool unused, List<MessageParam>? _params)
{
    public int Index { get; } = index;
    public string? Name { get; } = name;
    public bool Unused { get; } = unused;
    public List<MessageParam> Params { get; } = _params ?? [];
}