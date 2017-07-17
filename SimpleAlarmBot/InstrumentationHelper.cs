using BotBuilder.Instrumentation;
using BotBuilder.Instrumentation.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Microsoft.Bot.Sample.SimpleAlarmBot
{
    public class InstrumentationHelper
    {
        public static BotBuilder.Instrumentation.Interfaces.IBotFrameworkInstrumentation DefaultInstrumentation
        {
            get
            {
                return BotBuilder.Instrumentation.DependencyResolver.Current.DefaultInstrumentationWithCognitiveServices;
            }
        }
    }
}