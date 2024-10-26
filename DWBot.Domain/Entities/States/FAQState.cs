namespace DWBot.Domain.Entities.States;

public sealed class FAQState : BaseState
{
    public override Guid Id => new("FD1C1ED9-D8CF-4EC8-89B5-A5BD53B552A1");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(StartState),
    ];

    public override FAQStateView GetView()
    {
        return new FAQStateView(this);
    }
}
