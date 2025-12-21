using System.Drawing;
using p3rpc.commonmodutils;
using riri.flowscriptframework.Types.V4;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.test;

public class Registration : ModuleBase<FlowscriptContext>
{
    public Registration(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        // Define a custom Flowscript function that takes an integer and multiplies it by itself.
        // This example was borrowed from P5R Flowscript Framework: https://github.com/Secre-C/p5rpc.flowscriptframework
        
        // The included test script will print out this new number using PUT, so ensure that "Enable FlowScript Log Functions"
        // is enabled in Flowscript Frameworks' config.
        _context._flowLib.Register("SQUARE", [ParamType.Int], ParamType.Int, ctx =>
        {
            var num = ctx.GetIntArg(0);
            ctx.SetReturnValue(num * num);
            return FlowStatus.SUCCESS;
        });
        
        // Define a custom MessageScript function to set some text to any arbitrary RGB color value instead of from
        // a color preset as is the case with the color tag in existing Persona games.
        
        // This will appear when opening a save file in the SaveLoad menu.
        _context._msgLib.Register("rgb", 
            [new("red"), new("green"), new("blue")], 
            ctx =>
            {
                if (ctx.GetTagLevel() == 5 || ctx.GetTagLevel() < 1)
                    ctx.SetColor(Color.FromArgb(0xff, ctx.GetArg(0), ctx.GetArg(1), ctx.GetArg(2)));
                return false; // Return false so text doesn't get cut off
            }
        );
    }

    public override void Register()
    {
    }
}