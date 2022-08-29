using Jonas;
using Rappen.XTB.Helpers;

namespace Rappen.XRMTokens.Plugin
{
    public class AccountXRMTokens : JonasPluginBase
    {
        public override void Execute(JonasPluginBag bag)
        {
            var compose = bag.TargetEntity.GetAttributeValue<string>("jr_compose");
            var result = bag.TargetEntity.Substitute(bag.Service, compose);
            bag.TargetEntity["jr_result"] = result;
        }
    }

    public class Sss : JonasCodeActivityBase
    {

    }
}
