namespace DWBot.Domain.Entities.States;

public sealed class FAQState : BaseState
{
    public override Guid Id => new("FD1C1ED9-D8CF-4EC8-89B5-A5BD53B552A1");
    public override string Description => "Добро пожаловать в раздел \"Часто задаваемые вопросы\" ❓\r\n\r\n*вопрос 1\r\n# ответ 1\r\n\r\n*вопрос 2\r\n#ответ 2\r\n\r\nЗдесь вы найдете ответы на самые распространенные вопросы.";
    public override (string, string) ButtonConfig
        => ("Часто задаваемые вопросы", "/faq");
    public override string MenuConfig => "Если вы не нашли нужной информации, свяжитесь с нашими менеджерами.";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(StartState),
    ];
}
