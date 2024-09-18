using DWBot.Domain.Entities.States;

namespace DWBot.Helpers;

internal static class CommandMapper
{
    public static Type MapToState(string command) => command.Trim().ToUpper() switch
    {
        "/START" => typeof(StartState),
        "/DEVELOPMENT" => typeof(SoftwareDevelopmentState),
        "/DESKTOP" => typeof(DesktopState),
        "/BOTS" => typeof(BotsState),
        "/WEB" => typeof(WebState),
        "/AUTOMATION" => typeof(AutomationState),
        "/DESIGN" => typeof(ApplyState),
        "/CONSULTING" => typeof(ConsultingState),
        "/SUPPORT" => typeof(SupportState),
        "/FAQ" => typeof(FAQState),
        "/MANAGER" => typeof(ChatWithManagerState),
        "/APPLY" => typeof(ApplyState),
        "/BACK" => typeof(StartState),
        _ => typeof(NoneState)
    };
}
