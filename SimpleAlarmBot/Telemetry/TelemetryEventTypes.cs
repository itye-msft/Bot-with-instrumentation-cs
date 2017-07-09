using System;

namespace Microsoft.Bot.Sample.SimpleAlarmBot.Telemetry
{
    /// <summary>
    /// Define event type names used by TelemtryLogger.
    /// </summary>
    public static class TelemetryEventTypes
    {
        public const string MessageReceived = "MBFEvent.UserMessage";
        public const string MessageSent = "MBFEvent.BotMessage";
        public const string LuisIntentDialog = "MBFEvent.Intent";
        public const string MessageSentiment = "MBFEvent.Sentiment";
        public const string ConvertionStarted = "message.convert.start";
        public const string ConvertionEnded = "message.convert.end";
        public const string OtherActivity = "message.other";
        public const string ConversationUpdate = "MBFEvent.StartTransaction";
        public const string ConversationEnded = "MBFEvent.EndTransactiond";
        public const string QnaEvent = "MBFEvent.QNAEvent";
    }
}