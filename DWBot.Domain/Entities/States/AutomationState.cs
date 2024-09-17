namespace DWBot.Domain.Entities.States;

public class AutomationState : BaseState
{
    public override string Description => "automation";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
