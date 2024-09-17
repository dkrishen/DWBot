namespace DWBot.Services.StateMachine.States;

internal sealed class WebState : BaseState
{
    public override string Description => "web";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
