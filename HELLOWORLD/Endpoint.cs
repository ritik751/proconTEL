using ProconTel.CommunicationCenter.Kernel;
using ProconTel.Logging;

namespace helloworld_proconTEL
{
    [Endpoint(Name = "HelloWorld.Endpoint", SupportedRoles = SupportedRoles.None)]

  public class Demo : ChannelEndpointBase 
    {
       
        public override SubscriberStrategyBase InstantiateSubscriberStrategy(){
            return null;
        }
        public override ProviderStrategyBase InstantiateProviderStrategy(){
            return null;
        }
        public override void Initialize(){
         Logger.Information("Hello World. proconTEL");
        }

        public override void Terminate(){
            Logger.Information("Terminated.");
        }
    }
}
