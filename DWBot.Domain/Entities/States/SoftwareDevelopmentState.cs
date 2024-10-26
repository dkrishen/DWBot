namespace DWBot.Domain.Entities.States;

public sealed class SoftwareDevelopmentState : BaseState
{
    public override Guid Id => new("326AB17E-592E-497B-9CD7-384E7A473E13");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof (WebState),
        typeof (DesktopState),
        typeof (BotsState),
        typeof (AutomationState),
        typeof(StartState),
    ];

    public override SoftwareDevelopmentStateView GetView()
    {
        return new SoftwareDevelopmentStateView(this);
    }
}
