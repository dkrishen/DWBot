namespace DWBot.Domain.Entities.States;

public sealed class WebState : BaseState
{
    public override Guid Id => new("C75F1B71-5B24-45AD-8C34-964FCC77C91B");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override WebStateView GetView()
    {
        return new WebStateView(this);
    }
}
