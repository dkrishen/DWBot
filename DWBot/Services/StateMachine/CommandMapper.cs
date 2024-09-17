using DWBot.Services.StateMachine.States;

namespace DWBot.Services.StateMachine;

internal static class CommandMapper
{
    public static Type MapToState(string command) => command.Trim().ToUpper() switch
    {
        "/START" => typeof(StartState),
        "/DEVELOPMENT" => typeof(SoftwareDevelopmentState),
        "/CONSULTING" => typeof(ConsultingState),
        "/SUPPORT" => typeof(SupportState),
        "/FAQ" => typeof(FAQState),
        "/WEB" => typeof(WebState),
        "/DESKTOP" => typeof(DesktopState),
        "/BOTS" => typeof(BotsState),
        "/AUTOMATION" => typeof(AutomationState),
        "/MANAGER" => typeof(ChatWithManagerState),
        "/APPLY" => typeof(ApplyState),
        "/BACK" => typeof(StartState),
        _ => typeof(NoneState)
    };
}
