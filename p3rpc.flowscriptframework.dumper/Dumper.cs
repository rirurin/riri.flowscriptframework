using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using AtlusScriptLibrary.Common.Collections;
using AtlusScriptLibrary.Common.Libraries;
using NCalc.Exceptions;
using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.dumper.Configuration;
using Reloaded.Mod.Interfaces;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.dumper;


public class FlowscriptModuleFunctionConverter : JsonConverter<FlowScriptModuleFunction>
{
    public override FlowScriptModuleFunction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, FlowScriptModuleFunction value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Index", $"0x{value.Index:x4}");
        writer.WriteString("ReturnType", value.ReturnType);
        writer.WriteString("Name", value.Name);
        writer.WriteString("Description", value.Description);
        writer.WriteStartArray("Parameters");
        foreach (var Parameter in value.Parameters)
        {
            writer.WriteStartObject();
            writer.WriteString("Type", Parameter.Type);
            writer.WriteString("Name", Parameter.Name);
            writer.WriteString("Description", Parameter.Description);
            writer.WriteEndObject();
        }
        writer.WriteEndArray();
        writer.WriteEndObject();
    }
}

public class MessageScriptLibraryParameterConverter : JsonConverter<MessageScriptLibraryParameter>
{
    public override MessageScriptLibraryParameter? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, MessageScriptLibraryParameter value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Name", value.Name);
        writer.WriteString("Description", value.Description);
        writer.WriteEndObject();
    }
}

internal interface INameHeuristic
{
    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions);
    public string Name { get; }
}

internal class NameHeuristicBattle : INameHeuristic
{
    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions) 
        => (float)Functions.Count(x => x.Name.StartsWith("BTL_") || x.Name.StartsWith("AI_")) / Functions.Count;

    public string Name => "Battle";
}

internal class NameHeuristicCommon : INameHeuristic
{
    private static HashSet<string> CommonFunctions = ["SYNC", "WAIT", "PUT", "PUTF", "PUTS"];

    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions)
        => Functions.Count(x => CommonFunctions.Contains(x.Name)) * 0.2f;
    
    public string Name => "Common";
}

internal class NameHeuristicCommunity : INameHeuristic
{
    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions)
        => (float)Functions.Count(x => x.Name.StartsWith("CMM_")) / Functions.Count;
    
    public string Name => "Community";
}

internal class NameHeuristicEvent : INameHeuristic
{
    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions)
        => (float)Functions.Count(x => x.Name.StartsWith("EVT_")) / Functions.Count;
    
    public string Name => "Event";
}

internal class NameHeuristicField : INameHeuristic
{
    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions) 
        => (float)Functions.Count(x => x.Name.StartsWith("FLD_") || x.Name.StartsWith("DUNGEON_")) / Functions.Count;
    
    public string Name => "Field";
}

internal class NameHeuristicFacility : INameHeuristic
{
    public float GetNameConfidence(List<FlowScriptModuleFunction> Functions) 
        => (float)Functions.Count(x => x.Name.EndsWith("SHOP_LV") || x.Name.StartsWith("UI_")) / Functions.Count;
    
    public string Name => "Facility";
}

public class FlowscriptDumpSection(string name, List<FlowScriptModuleFunction> functions)
{
    public string Name { get; } = name;
    public List<FlowScriptModuleFunction> Functions { get; } = functions;
}

public class WrapperWriter(Stream stream) : StreamWriter(stream)
{
    private int IndentLevel { get; set; }

    public void Indent() => IndentLevel++;
    public void Unindent() => IndentLevel = int.Max(IndentLevel - 1, 0);

    public void StartBracket()
    {
        WriteLine("{");
        Indent();
    }

    public void EndBracket()
    {
        Unindent();
        WriteLine("}");
    }

    public override void WriteLine(string? value)
        => base.WriteLine($"{new string('\t', IndentLevel)}{value}");
}

public unsafe class Dumper(DumperContext context, Dictionary<string, ModuleBase<DumperContext>> modules)
    : ModuleBase<DumperContext>(context, modules)
{
    private static List<INameHeuristic> NameHeuristics = [
        new NameHeuristicBattle(), new NameHeuristicCommon(), new NameHeuristicCommunity(),
        new NameHeuristicEvent(), new NameHeuristicField(), new NameHeuristicFacility()
    ];
    
    private string SelectBestSectionName(List<FlowScriptModuleFunction> Functions)
    {
        var Result = NameHeuristics.Select(x => (x.Name, x.GetNameConfidence(Functions))).ToList();
        Result.Sort((a, b) => a.Item2.CompareTo(b.Item2));
        return Result.Last().Name;
    }

    private string NameFromFlowscriptModules(List<FlowScriptModule> Modules, int SectionIndex)
    {
        var TargetModule = Modules.Find(x => x.Functions.First().Index >> 0xc == SectionIndex);
        return TargetModule?.Name ?? string.Empty;
    }
    
    private void DumpFunctions()
    {
        // FlowScript
        var Config = (Config)_context._config;
        var AllFunctions = _context._flowLib.GetAllFunctions();
        var VanillaEnds = _context._flowLib.GetVanillaSectionEnds();
        var TargetLibPath = Path.Combine(_context._modLocation, "Libraries", $"{Config.TargetLibrary}.json");
        var TargetLib = Path.Exists(TargetLibPath)
            ? JsonSerializer.Deserialize<Library>(File.ReadAllText(TargetLibPath)) : null;
        var WriterOptions = new JsonWriterOptions { Indented = true };
        var SerializedOptions = new JsonSerializerOptions { WriteIndented = true };
        SerializedOptions.Converters.AddRange(
            new FlowscriptModuleFunctionConverter(),
            new MessageScriptLibraryParameterConverter()
            );
        var DumpDir = Path.Join(_context._modLocation, "Dumps", Config.TargetLibrary);
        Directory.CreateDirectory(DumpDir);
        // Create a list for each vanilla section + custom section
        List<FlowscriptDumpSection> SectionList = new();
        foreach (var (Index, End) in VanillaEnds.Select((x, i) => (i, x)))
        {
            var SectionFunctions = AllFunctions
                .Where(x => x.Index >> 0xc == Index && (x.Index & 0xfff) < End)
                .Select(x => x.ToAst())
                .ToList();
            var SectionName = (TargetLib != null ? NameFromFlowscriptModules(TargetLib.FlowScriptModules, Index) : null) 
                              ?? SelectBestSectionName(SectionFunctions);
            SectionList.Add(new(SectionName, SectionFunctions));
        }
        var Custom = AllFunctions
            .Where(x =>
            {
                var (Sec, Index) = (x.Index >> 0xc, x.Index & 0xfff);
                return Sec >= VanillaEnds.Count || Index >= VanillaEnds[Sec];
            })
            .Select(x => x.ToAst())
            .ToList();
        if (Custom.Count > 0) SectionList.Add(new("Custom", Custom));
        // Create FlowscriptModules JSON
        using var SectionsDecl = new Utf8JsonWriter(new FileStream(Path.Join(DumpDir, "FlowScriptModules.json"), FileMode.Create), WriterOptions);
        SectionsDecl.WriteStartArray();
        foreach (var Section in SectionList)
        {
            SectionsDecl.WriteStartObject();
            SectionsDecl.WriteString("Name", Section.Name);
            SectionsDecl.WriteString("ShortName", Section.Name);
            SectionsDecl.WriteString("Description", $"{Section.Name} related functions.");
            SectionsDecl.WriteString("ConstantsPath", "");
            SectionsDecl.WriteString("EnumsPath", "");
            SectionsDecl.WriteString("FunctionsPath", $"{Config.TargetLibrary}/Modules/{Section.Name}/Functions.json");
            SectionsDecl.WriteEndObject();
        }
        SectionsDecl.WriteEndArray();
        SectionsDecl.Dispose();
        foreach (var Section in SectionList)
        {
            var SectionDir = Path.Join(DumpDir, "Modules", Section.Name);
            Directory.CreateDirectory(SectionDir);
            var SectionFile = Path.Join(SectionDir, "Functions.json");
            using var DumpFile = new Utf8JsonWriter(new FileStream(SectionFile, FileMode.Create), WriterOptions);
            DumpFile.WriteStartArray();   
            foreach (var Func in Section.Functions)
                JsonSerializer.Serialize(DumpFile, Func, SerializedOptions);
            DumpFile.WriteEndArray();
            Log.Information($"{nameof(Dumper)} || Wrote {Section.Functions.Count} functions into '{SectionFile}'");
            DumpFile.Dispose();
        }
        
        // MessageScript
        var MsgSections = _context._msgLib.GetAllFunctions();
        var MsgFile = Path.Join(DumpDir, "MessageScriptLibrary.json");
        using var MsgDecl = new Utf8JsonWriter(new FileStream(MsgFile, FileMode.Create), WriterOptions);
        MsgDecl.WriteStartArray();
        foreach (var Section in MsgSections)
        {
            var ExistSec = TargetLib?.MessageScriptLibraries.Find(x => x.Index == Section.Index);
            MsgDecl.WriteStartObject();
            MsgDecl.WriteNumber("Index", Section.Index);
            MsgDecl.WriteString("Name", ExistSec?.Name ?? "");
            MsgDecl.WriteString("Description", ExistSec?.Description ?? "");
            MsgDecl.WriteStartArray("Functions");
            foreach (var Function in Section.Functions.Select(x => x.ToAst()))
            {
                var ExistFunc = ExistSec?.Functions.Find(x => x.Index == Function.Index);
                MsgDecl.WriteStartObject();
                MsgDecl.WriteNumber("Index", Function.Index);
                
                MsgDecl.WriteString("Name", Function.Name != string.Empty ? Function.Name : ExistFunc?.Name ?? "");
                MsgDecl.WriteString("Description", Function.Description != string.Empty ? Function.Description : ExistFunc?.Description ?? "");
                if (Function.Semantic == MessageScriptLibraryFunctionSemantic.Unused)
                    MsgDecl.WriteString("Semantic", "Unused");
                MsgDecl.WriteStartArray("Parameters");
                if (Function.Parameters.Count > 0)
                    foreach (var Param in Function.Parameters)
                        JsonSerializer.Serialize(MsgDecl, Param, SerializedOptions);
                else if (ExistFunc != null)
                    foreach (var Parameter in ExistFunc.Parameters)
                        JsonSerializer.Serialize(MsgDecl, Parameter, SerializedOptions);
                MsgDecl.WriteEndArray();
                MsgDecl.WriteEndObject();
            }
            MsgDecl.WriteEndArray();
            MsgDecl.WriteEndObject();
        }
        Log.Information($"{nameof(Dumper)} || Wrote MessageScript functions into {MsgFile}");
        MsgDecl.WriteEndArray();
        MsgDecl.Dispose();
    }

    private void GenerateWrapper()
    {
        var Config = (Config)_context._config;
        var WrapperPath = Path.Combine(_context._modLocation, "Wrapper");
        Directory.CreateDirectory(WrapperPath);
        var WrapperFile = Path.Join(WrapperPath, $"{Config.TargetLibrary}.cs");
        var AllFunctions = _context._flowLib.GetAllFunctions();
        using var WrapperWriter = new WrapperWriter(new FileStream(WrapperFile, FileMode.Create));
        WrapperWriter.WriteLine("// ReSharper disable InconsistentNaming");
        WrapperWriter.WriteLine("using p3rpc.flowscriptframework.Interfaces;");
        WrapperWriter.WriteLine($"namespace {Config.WrapperNamespace};");
        WrapperWriter.WriteLine("public class Wrappers(IFlowFramework flowLib)");
        WrapperWriter.StartBracket();
        WrapperWriter.WriteLine("private IFlowFramework FlowLib { get; } = flowLib;");
        WrapperWriter.WriteLine();
        foreach (var Function in AllFunctions)
        {
            var ParamList = string.Join(", ", 
                Function.Parameters.Select(x => $"{x.Type.ToAst()} {x.Name}"));
            WrapperWriter.WriteLine($"public {Function.ReturnType.ToAst()} {Function.Name}({ParamList}) =>");
            WrapperWriter.Indent();
            var ParamTransfer = string.Join(", ", 
                Function.Parameters.Select(x => $"new {x.Type.ToInvokeParam()}({x.Name})"));
            WrapperWriter.WriteLine($"FlowLib.Invoke{Function.ReturnType}(\"{Function.Name}\", [{ParamTransfer}]);");
            WrapperWriter.Unindent();
        }
        WrapperWriter.EndBracket();
        WrapperWriter.Dispose();
    }

    public override void Register() {}

    public override void OnConfigUpdated(IConfigurable newConfig)
    {
        DumpFunctions();
        GenerateWrapper();
    }
}