namespace DWBot.Domain.Entities.States;

public sealed class WebState : BaseState
{
    public override Guid Id => new("C75F1B71-5B24-45AD-8C34-964FCC77C91B");
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
