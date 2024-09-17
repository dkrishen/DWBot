namespace DWBot.Services.StateMachine.States;

internal sealed class ConsultingState : BaseState
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
