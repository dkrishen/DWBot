namespace DWBot.Services.StateMachine.States;

internal sealed class SoftwareDevelopmentState : BaseState
{
    public override string Description => "software";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof (WebState),
        typeof (DesktopState),
        typeof (BotsState),
        typeof (AutomationState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
