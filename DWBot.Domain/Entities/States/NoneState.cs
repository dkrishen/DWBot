namespace DWBot.Domain.Entities.States;

public sealed class NoneState : BaseState
{
    public override Guid Id => new("373ED21C-DDE1-4E27-91A9-CD122AAF56FB");
    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override NoneStateView GetView()
    {
        return new NoneStateView(this);
    }
}
