namespace DWBot.Services.StateMachine.States;

internal sealed class BackState : BaseState
{
    public override string Description => "back";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
