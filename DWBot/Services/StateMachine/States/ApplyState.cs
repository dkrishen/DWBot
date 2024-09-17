namespace DWBot.Services.StateMachine.States;

internal sealed class ApplyState : BaseState
{
    public override string Description => "apply";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ApplicationFormState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
