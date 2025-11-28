using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.test;

public class Registration : ModuleBase<FlowscriptContext>
{
    public Registration(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        // Example from P5R Flowscript Framework
        _context._flowLib.Register("SQUARE", 1, ctx =>
        {
            var num = ctx.GetIntArg(0);
            ctx.SetReturnValue(num * num);
            return FlowStatus.SUCCESS;
        });
    }

    public override void Register()
    {
    }
}