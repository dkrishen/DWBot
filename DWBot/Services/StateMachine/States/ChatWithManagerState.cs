namespace DWBot.Services.StateMachine.States;

internal sealed class ChatWithManagerState : BaseState
{
    public override string Description => "chat with manager";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override void OnEntry() { }
    public override void OnExit()
    {
        // redirect to chat
    }
}
