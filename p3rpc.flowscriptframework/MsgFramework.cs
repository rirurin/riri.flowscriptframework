using p3rpc.commonmodutils;
using p3rpc.flowscriptframework.Interfaces;

namespace p3rpc.flowscriptframework;

public class MsgFramework : ModuleBase<FlowscriptContext>, IMsgFramework
{
    public MsgFramework(FlowscriptContext context, Dictionary<string, ModuleBase<FlowscriptContext>> modules) : base(context, modules)
    {
    }

    public override void Register()
    {
    }
}