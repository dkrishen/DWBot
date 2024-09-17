namespace DWBot.Domain.Entities.States;

public sealed class BotsState : BaseState
{
    public override string Description => "bot";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
