namespace DWBot.Domain.Entities.States;

public sealed class ChatWithManagerState : BaseState
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
