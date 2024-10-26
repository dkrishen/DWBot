using DWBot.Domain.Entities.States;

namespace DWBot.Domain;

public static class CommandMapper
{
    private static readonly Tuple<string, Type, string>[] Mapping = [
        new (Commands.Start, typeof(StartState), "Вернуться на главную"),
        new (Commands.Development, typeof(SoftwareDevelopmentState), "Разработка ПО"),
        new (Commands.Desktop, typeof(DesktopState), "Разработка десктопных приложений"),
        new (Commands.Bots, typeof(BotsState), "Разработка ботов"),
        new (Commands.Web, typeof(WebState), "Веб-разработка"),
        new (Commands.Automation, typeof(AutomationState), "Автоматизация процессов"),
        new (Commands.Design, typeof(DesignState), "Дизайн"),
        new (Commands.Translation, typeof(TranslationState), "Локализация"),
        new (Commands.SoftwareTranslation, typeof(SoftwareTranslationState), "Локализация приложений"),
        new (Commands.TextTranslation, typeof(TextTranslationState), "Технический перевод"),
        new (Commands.ContentTranslation, typeof(ContentTranslationState), "Контент для глобальных рынков"),
        new (Commands.Consulting, typeof(ConsultingState), "Консалтинг"),
        new (Commands.Support, typeof(SupportState), "Поддержка"),
        new (Commands.Price, typeof(PriceState), "Прайс"),
        new (Commands.Faq, typeof(FAQState), "Часто задаваемые вопросы"),
        new (Commands.Manager, typeof(ChatWithManagerState), "Связаться с менеджером"),
        new (Commands.Apply, typeof(ApplyState), "Оставить заявку"),
        new (Commands.Back, typeof(StartState), ""),
        new (string.Empty, typeof(NoneState), string.Empty),
    ];

    public static Type MapToState(string command)
    {
        var cleanedCommand = command.Trim().ToUpper();
        var map = Mapping.FirstOrDefault(x => x.Item1 == cleanedCommand);

        return map is null ? typeof(NoneState) : map.Item2;
    }

    public static string ButtonTextByStateType(Type stateType)
    {
        if (!stateType.IsSubclassOf(typeof(BaseState)))
            return string.Empty;
        
        var stateTypeFullName = stateType.FullName;

        return Mapping.FirstOrDefault(x => x.Item2.FullName == stateTypeFullName)?.Item3 ?? string.Empty;
    }

    public static string CommandTextByStateType(Type stateType)
    {
        if (!stateType.IsSubclassOf(typeof(BaseState)))
            return string.Empty;

        var stateTypeFullName = stateType.FullName;
        
        return Mapping.FirstOrDefault(x => x.Item2.FullName == stateTypeFullName)?.Item1 ?? string.Empty;
    }
}
