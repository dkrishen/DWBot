namespace DWBot.Domain.Entities.States;

public sealed class DesktopState : BaseState
{
    public override string Description => "desktop";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
