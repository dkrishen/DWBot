namespace DWBot.Domain.Entities.States;

public sealed class ChatWithManagerState : BaseState
{
    public override string Description => "Свяжитесь с менеджером 💬\r\n\r\nНаш менеджер ответит на все ваши вопросы и поможет выбрать оптимальное решение для вашего бизнеса.\r\n\r\nhttps://t.me/miyarc";
    public override (string, string) ButtonConfig
        => ("Связаться с менеджером", "/manager");
    public override string MenuConfig => "Назад:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];
}
