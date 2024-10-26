namespace DWBot.Domain.Entities.States;

public sealed class TextTranslationState : BaseState
{
    public override Guid Id => new("191AD54E-FBD6-4A54-84D8-F1B2A3651446");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override TextTranslationStateView GetView()
    {
        return new TextTranslationStateView(this);
    }
}
