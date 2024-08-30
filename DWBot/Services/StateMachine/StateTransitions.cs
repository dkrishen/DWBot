using DWBot.Services.StateMachine;
using DWBot.Services.StateMachine.States;

internal static class BotStateConfiguration
{
    public static readonly Dictionary<BotStates, BaseState> States = new()
    {
        {BotStates.Start, new StartState() },
        { BotStates.SoftwareDevelopment, new SoftwareDevelopmentState() },
        { BotStates.Consulting, new ConsultingState() },
        { BotStates.Support, new SupportState() },
        { BotStates.FAQ, new FAQState() },
        { BotStates.Web, new WebState() },
        { BotStates.Desktop, new DesktopState() },
        { BotStates.Bots, new BotsState() },
        { BotStates.Automation, new AutomationState() },
        { BotStates.ChatWithManager, new ChatWithManagerState() },
        { BotStates.Apply, new ApplyState() },
        { BotStates.Back, new BackState() },
        { BotStates.Question, new QuestionState() },
        { BotStates.ApplicationForm, new ApplyState() },
    };
}