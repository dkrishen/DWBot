namespace DWBot.Domain.Entities.States;

public sealed class ChatWithManagerState : BaseState
{
    public override Guid Id => new("FEFF7315-5007-4A8B-8240-2715DF7B0E1E");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override ChatWithManagerStateView GetView()
    {
        return new ChatWithManagerStateView(this);
    }
}
