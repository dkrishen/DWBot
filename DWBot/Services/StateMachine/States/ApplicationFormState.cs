namespace DWBot.Services.StateMachine.States;

internal sealed class ApplicationFormState : BaseState
{
    public override string Description => "application form";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
