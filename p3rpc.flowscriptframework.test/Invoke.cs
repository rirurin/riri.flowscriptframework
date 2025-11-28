using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;
using Reloaded.Hooks.Definitions;
using RyoTune.Persona3Reload.Types;
using RyoTune.Reloaded;

namespace p3rpc.flowscriptframework.test;

public class Invoke : ModuleBase<FlowscriptContext>
{
    private nint GlobalWork = 0;
    
    public unsafe delegate void AOtHUD_Tick(AOtHUD* self, float delta);

    private IHook<AOtHUD_Tick> _AOtHudTick;

    private unsafe void AOtHUD_TickImpl(AOtHUD* self, float delta)
    {
        if ((Native.GetAsyncKeyState(0x31) & 1) != 0)
        {
            for (var i = 0; i < 256; i++)
            {
                var Res = _context._flowLib.InvokeInt("GET_COUNT", [new IntParam(i)]);
                Log.Debug($"{nameof(Invoke)} || GET_COUNT({i}) = {Res}");
            }

            for (var i = 0; i < 20; i++)
            {
                var square = _context._flowLib.InvokeInt("SQUARE", [new IntParam(i)]);
                Log.Debug($"{nameof(Invoke)} || SQUARE({i}) = {square}");
            }
        }
        _AOtHudTick.OriginalFunction(self, delta);
    }
    
    public unsafe Invoke(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
        _context._toolkitClasses.AddConstructor<UGlobalWork>(obj => GlobalWork = (nint)obj.Self);
        _context._toolkitClasses.AddConstructor<AOtHUD>(obj =>
        {
            _AOtHudTick ??= _context._hooks.CreateHook<AOtHUD_Tick>(AOtHUD_TickImpl,
                *(nint*)(((nativetypes.Interfaces.UObject*)obj.Self)->_vtable + 0x460)).Activate();
        });
    }

    public override void Register()
    {
    }
}