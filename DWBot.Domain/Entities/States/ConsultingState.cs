namespace DWBot.Domain.Entities.States;

public sealed class ConsultingState : BaseState
{
    public override string Description => "consalting state";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
