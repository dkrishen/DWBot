namespace DWBot.Domain.Entities.States;

public sealed class ChatWithManagerState : BaseState
{
    public override Guid Id => new("FEFF7315-5007-4A8B-8240-2715DF7B0E1E");
    public override string Description => "Свяжитесь с менеджером 💬\r\n\r\nНаш менеджер ответит на все ваши вопросы и поможет выбрать оптимальное решение для вашего бизнеса.\r\n\r\nhttps://t.me/miyarc";
    public override (string, string) ButtonConfig
        => ("Связаться с менеджером", "/manager");
    public override string MenuConfig => "Назад:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];
}
