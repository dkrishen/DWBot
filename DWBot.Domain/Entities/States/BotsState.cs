namespace DWBot.Domain.Entities.States;

public sealed class BotsState : BaseState
{
    public override Guid Id => new("73830597-3A3A-47E8-B1C6-2B326F65958E");
    public override string Description => "Вы выбрали \"Разработка ботов\" 🤖\r\n\r\nМы создаем интеллектуальных ботов, которые помогут вам автоматизировать общение с клиентами и улучшить сервис.";
    public override (string, string) ButtonConfig
        => ("Разработка ботов", "/bots");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
