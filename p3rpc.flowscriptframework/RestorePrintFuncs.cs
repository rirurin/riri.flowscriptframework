using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Configuration;
using p3rpc.flowscriptframework.Interfaces;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework;

public class RestorePrintFuncs(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules)
    : ModuleBase<FlowscriptContext>(context, modules)
{

    private FlowFramework? _flowFramework;

    private FlowStatus PutInt(IScriptState ctx)
    {
        if (((Config)_context._config).EnableLogFunctions)
        {
            Log.Information($"{ctx.GetIntArg(0)}");
        }
        return FlowStatus.SUCCESS;       
    }
    
    private FlowStatus PutString(IScriptState ctx)
    {
        if (((Config)_context._config).EnableLogFunctions)
        {
            Log.Information($"{ctx.GetStringArg(0)}");
        }
        return FlowStatus.SUCCESS;       
    }
    
    private FlowStatus PutFloat(IScriptState ctx)
    {
        if (((Config)_context._config).EnableLogFunctions)
        {
            Log.Information($"{ctx.GetFloatArg(0)}");
        }
        return FlowStatus.SUCCESS;       
    }

    public override void Register()
    {
        _flowFramework = GetModule<FlowFramework>();
        
        _flowFramework.Register("PUT", [ParamType.Int], ParamType.Void, PutInt, 2);
        _flowFramework.Register("PUTS", [ParamType.String], ParamType.Void, PutString, 3);
        _flowFramework.Register("PUTF", [ParamType.Float], ParamType.Void, PutFloat, 4);
        _flowFramework.Register("DBG_PUT", [ParamType.Int], ParamType.Void, PutInt, 0x20);
        _flowFramework.Register("DBG_PUTS", [ParamType.String], ParamType.Void, PutString, 0x21);
    }
}