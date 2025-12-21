using AtlusScriptLibrary.Common.Libraries;
using p3rpc.flowscriptframework.Interfaces;
using riri.flowscriptframework.Types.V4;

namespace p3rpc.flowscriptframework.dumper;

public static class TypeExtensions
{
    public static FlowScriptModuleFunction ToAst(this FlowscriptJson Self)
        => new FlowScriptModuleFunction
        {
            Index = (uint)Self.Index,
            ReturnType = Self.ReturnType.ToAst(),
            Name = Self.Name,
            Description = Self.Description,
            Parameters = Self.Parameters.Select(x => x.ToAst()).ToList()
        };

    public static FlowScriptModuleParameter ToAst(this FlowscriptJsonParameters Self)
        => new FlowScriptModuleParameter
        {
            Type = Self.Type.ToAst(),
            Name = Self.Name,
            Description = Self.Description,
        };

    public static string ToAst(this ParamType Self)
        => Self switch
        {
            ParamType.Void => "void",
            ParamType.Int => "int",
            ParamType.Float => "float",
            ParamType.String => "string",
            _ => "unknown"
        };

    public static string ToInvokeParam(this ParamType Self)
        => Self switch
        {
            ParamType.Int => nameof(IntParam),
            ParamType.Float => nameof(FloatParam),
            ParamType.String => nameof(StringParam),
            _ => throw new Exception($"Cannot handle a parameter of type {Self}")
        };

    public static MessageScriptLibrary ToAst(this MessageSectionJson Self)
        => new MessageScriptLibrary
        {
            Index = Self.Index,
            Name = "",
            Description = "",
            Functions = Self.Functions.Select(x => x.ToAst()).ToList()
        };
    
    public static MessageScriptLibraryFunction ToAst(this MessageFunctionJson Self)
        => new MessageScriptLibraryFunction
        {
            Index = Self.Index,
            Name = Self.Name ?? "",
            Description = "",
            Semantic = Self.Unused 
                ? MessageScriptLibraryFunctionSemantic.Unused
                : MessageScriptLibraryFunctionSemantic.Normal,
            Parameters = Self.Params.Select(x => x.ToAst()).ToList()
        };

    public static MessageScriptLibraryParameter ToAst(this MessageParam Self)
        => new MessageScriptLibraryParameter
        {
            Name = Self.Name ?? "",
            Description = Self.Desc ?? ""
        };
}