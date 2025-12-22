#pragma warning disable CS1591

namespace riri.flowscriptframework.Types.V4;

public class FlowscriptJson
{
    public int Index { get; }
    public ParamType ReturnType { get; }
    public string Name { get; }
    public string Description { get; }
    public FlowscriptJsonParameters[] Parameters { get; }

    public FlowscriptJson(int _Index, ParamType _ReturnType, string _Name, ParamType[] _Parameters)
    {
        Index = _Index;
        ReturnType = _ReturnType;
        Name = _Name;
        Description = string.Empty;
        Parameters = _Parameters.Select((parm, i) 
            => new FlowscriptJsonParameters(parm, $"param{i}", string.Empty)).ToArray();
    }
}

public class FlowscriptJsonParameters(ParamType type, string name, string description)
{
    public ParamType Type { get; } = type;
    public string Name { get; } = name;
    public string Description { get; } = description;
}