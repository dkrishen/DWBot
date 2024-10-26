namespace DWBot.Domain.Entities.States;

public sealed class BotsState : BaseState
{
    public override Guid Id => new("73830597-3A3A-47E8-B1C6-2B326F65958E");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override BotsStateView GetView()
    {
        return new BotsStateView(this);
    }
}
