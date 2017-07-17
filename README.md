# Bot-with-instrumentation-cs
## What's inside?
A web bot project that sends telemetry to Application Insights using [BotBuilder.Instrumentation library](https://www.nuget.org/packages/BotBuilder.Instrumentation/)

The bot is able to create an "Alarm" to be triggered at a certain time later on. The bot will print to the screen a message when the alarm is triggered. 

This project uses LUIS cognitive services to detect intents. It means that the user can use natuarl language and free text to create the alarm, and the bot will understand the intent. 

For example, you can create an alarm called `breakfest time` in 10 minutes from now, by sending the following text to the bot: `create alarm Breakfest Time in 10 minutes` and the following command will do the same `set alarm Breakfest Time in ten minutes`

## How to view the data sent?
You can see the dashboard created in [here ibex-dashboard](https://github.com/CatalystCode/ibex-dashboard)

## Points of interest
* The `RootDialog` is inherited from `InstrumentedLuisDialog<object>` and it will automatically send all messages to the telemetry.
* You can manually send events, as can be seen in `Alarm.cs`, where the event not sent from inside a dialog and therefore is not be automatically logged. 
* `InstrumentationHelper` encapsulates the builtin dependancy resolver of `BotBuilder.Instrumentation`, however you can create your own implementation.  