namespace DWBot.Services.StateMachine.States;

internal sealed class QuestionState : BaseState
{
    public override string Description => "question";


    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(FAQState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
