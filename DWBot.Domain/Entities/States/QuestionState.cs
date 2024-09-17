namespace DWBot.Domain.Entities.States;

public sealed class QuestionState : BaseState
{
    public override string Description => "question";


    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(FAQState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
