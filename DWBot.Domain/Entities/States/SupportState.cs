namespace DWBot.Domain.Entities.States;

public sealed class SupportState : BaseState
{
    public override Guid Id => new("8B9288B3-4D97-44D3-BA6E-BACB6AD01593");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override SupportStateView GetView()
    {
        return new SupportStateView(this);
    }
}
