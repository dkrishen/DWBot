namespace DWBot.Domain.Entities.States;

public sealed class FAQState : BaseState
{
    public override string Description => "fack you";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(QuestionState),
        typeof(BackState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
