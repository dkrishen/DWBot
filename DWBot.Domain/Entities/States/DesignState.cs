namespace DWBot.Domain.Entities.States;

public sealed class DesignState : BaseState
{
    public override Guid Id => new("42ABDDF5-069C-4858-9DF4-321CE5F06BDD");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override DesignStateView GetView()
    {
        return new DesignStateView(this);
    }
}
