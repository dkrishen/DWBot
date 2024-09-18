namespace DWBot.Domain.Entities.States;

public sealed class WebState : BaseState
{
    public override string Description => "Вы выбрали \"Веб-разработка\" 🌐\r\n\r\nМы создадим для вас профессиональный сайт, соответствующий последним стандартам UX/UI.";
    public override (string, string) ButtonConfig
        => ("Веб-разработка", "/web");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
