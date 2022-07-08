using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using CustomReceiver.Models;
using System.Threading.Tasks;

namespace CustomReceiver.WebHookHandlers
{
    public class GenericJsonWebHookHandler : WebHookHandler
    {
        public GenericJsonWebHookHandler()
        {
            this.Receiver = "genericjson";
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            // Get JSON from WebHook
            JObject data = context.GetDataOrDefault<JObject>();
            string eventTriggered = (string)data["eventType"];

            switch (eventTriggered)
            {
                case "AGENT_JOINED":
                    //var jsonString = JsonConvert.SerializeObject(data);
                    var agentJoined = data.ToObject<AgentJoined>();
                    break;

                default: break;
            }

            return Task.FromResult(true);
        }
    }
}