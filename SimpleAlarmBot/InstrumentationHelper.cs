using BotBuilder.Instrumentation;
using BotBuilder.Instrumentation.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Microsoft.Bot.Sample.SimpleAlarmBot
{
    public class InstrumentationHelper
    {
        public static readonly BotFrameworkApplicationInsightsInstrumentation DefaultInstrumentation = new BotFrameworkApplicationInsightsInstrumentation(
            new BotBuilder.Instrumentation.Instumentation.InstrumentationSettings
            {
                InstrumentationKeys = new List<string>(new string[] { ConfigurationManager.AppSettings["InstrumentationKey"] }),
                OmitUsernameFromTelemetry = Convert.ToBoolean(ConfigurationManager.AppSettings["InstrumentationShouldOmitUsernameFromTelemetry"]),
                SentimentManager = new SentimentManager(
                            ConfigurationManager.AppSettings["TextAnalyticsApiKey"],
                            ConfigurationManager.AppSettings["TextAnalyticsMinLenght"],
                            ConfigurationManager.AppSettings["CognitiveServiceApiEndpoint"]
                            )
            });
    }
}