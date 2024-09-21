namespace DWBot.Domain.Entities.States;

public sealed class SoftwareDevelopmentState : BaseState
{
    public override Guid Id => new("326AB17E-592E-497B-9CD7-384E7A473E13");
    public override string Description => "Вы выбрали \"Разработка ПО\" 🖥\r\n\r\nНаша команда поможет вам создать надежное и современное программное обеспечение, которое идеально подойдет для вашего бизнеса.";
    public override (string, string) ButtonConfig
        => ("Разработка ПО", "/development");
    public override string MenuConfig => "Выберите, какое ПО вас интересует:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof (WebState),
        typeof (DesktopState),
        typeof (BotsState),
        typeof (AutomationState),
        typeof(StartState),
    ];
}
