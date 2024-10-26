namespace DWBot.Domain.Entities.States;

public sealed class ContentTranslationState : BaseState
{
    public override Guid Id => new("0775028D-B055-42ED-85B4-259E97D30046");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override ContentTranslationStateView GetView()
    {
        return new ContentTranslationStateView(this);
    }
}
