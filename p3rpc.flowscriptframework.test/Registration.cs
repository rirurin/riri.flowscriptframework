using p3rpc.commonmodutils;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.test;

public class Registration : ModuleBase<FlowscriptContext>
{
    public Registration(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        // Example from P5R Flowscript Framework
        _context._flowLib.Register("SQUARE", [ParamType.Int], ParamType.Int, ctx =>
        {
            var num = ctx.GetIntArg(0);
            ctx.SetReturnValue(num * num);
            return FlowStatus.SUCCESS;
        });
        _context._msgLib.Register("rgb", 
            [new("red"), new("green"), new("blue")], 
            ctx => { 
                var (r, g, b) = (ctx.GetArg(0), ctx.GetArg(1), ctx.GetArg(2));
                Log.Debug($"TODO: Show as RGB #{r:X2}{g:X2}{b:X2}");
                return true;
        });
    }

    public override void Register()
    {
    }
}