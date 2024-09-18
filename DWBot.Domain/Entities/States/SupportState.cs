namespace DWBot.Domain.Entities.States;

public sealed class SupportState : BaseState
{
    public override string Description => "Вы выбрали \"Поддержка\" 🛠\r\n\r\nМы обеспечим надежную поддержку и обслуживание ваших систем, чтобы они работали без перебоев и сбоев.";
    public override (string, string) ButtonConfig
        => ("Поддержка", "/support");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
