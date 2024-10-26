namespace DWBot.Domain.Entities.States;

public sealed class TranslationState : BaseState
{
    public override Guid Id => new("A2CAE257-6A38-457D-84BC-7666C485C4C7");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof (SoftwareTranslationState),
        typeof (TextTranslationState),
        typeof (ContentTranslationState),
        typeof (StartState),
    ];

    public override TranslationStateView GetView()
    {
        return new TranslationStateView(this);
    }
}
