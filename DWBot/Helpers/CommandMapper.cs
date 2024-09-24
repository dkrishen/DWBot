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
        "/DESIGN" => typeof(DesingState),
        "/TRANSLATION" => typeof(TranslationState),
        "/SOFTWARE-TRANSLATION" => typeof(SoftwareTranslationState),
        "/TEXT-TRANSLATION" => typeof(TextTranslationState),
        "/CONTENT-TRANSLATION" => typeof(ContentTranslationState),
        "/CONSULTING" => typeof(ConsultingState),
        "/SUPPORT" => typeof(SupportState),
        "/PRICE" => typeof(PriceState),
        "/FAQ" => typeof(FAQState),
        "/MANAGER" => typeof(ChatWithManagerState),
        "/APPLY" => typeof(ApplyState),
        "/BACK" => typeof(StartState),
        _ => typeof(NoneState)
    };
}
