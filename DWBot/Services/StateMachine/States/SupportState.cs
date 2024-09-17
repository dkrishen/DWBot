namespace DWBot.Services.StateMachine.States;

internal sealed class SupportState : BaseState
{
    public override string Description => "We can help you with supporting of your app!";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
