using System.Web;
using System.Web.Http;

namespace Microsoft.Bot.Sample.SimpleAlarmBot
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Configure Web API.
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}