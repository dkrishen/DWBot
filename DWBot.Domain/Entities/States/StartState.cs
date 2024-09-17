namespace DWBot.Domain.Entities.States;

public sealed class StartState : BaseState
{
    public override string Description => "Hellooo!";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(SoftwareDevelopmentState),
        typeof(ConsultingState),
        typeof(SupportState),
        typeof(FAQState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
