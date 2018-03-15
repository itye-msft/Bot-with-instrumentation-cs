using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.Http;
using BotBuilder.Instrumentation;
using BotBuilder.Instrumentation.Instumentation;

namespace Microsoft.Bot.Sample.SimpleAlarmBot
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Configure Web API.
            GlobalConfiguration.Configure(WebApiConfig.Register);

            RegisterInstrumentation();
        }

        private static void RegisterInstrumentation()
        {
            var instrumentationKey = ConfigurationManager.AppSettings["InstrumentationKey"];
            bool.TryParse(
                ConfigurationManager.AppSettings["InstrumentationShouldOmitUsernameFromTelemetry"],
                out var instrumentationShouldOmitUsernameFromTelemetry);
            new BotFrameworkApplicationInsightsInstrumentation(
                new InstrumentationSettings
                {
                    InstrumentationKeys = new List<string> { instrumentationKey },
                    OmitUsernameFromTelemetry = instrumentationShouldOmitUsernameFromTelemetry
                });
        }
    }
}