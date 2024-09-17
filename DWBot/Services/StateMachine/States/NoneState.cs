namespace DWBot.Services.StateMachine.States;

internal sealed class NoneState : BaseState
{
    public override string Description => "none";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
