#pragma warning disable CS1591

namespace riri.flowscriptframework.Types.V4;

public enum StackType : byte
{
    Int,
    Float,
    GlobalInt,
    GlobalFloat,
    String,
    LocalInt,
    LocalFloat,
    Return
}