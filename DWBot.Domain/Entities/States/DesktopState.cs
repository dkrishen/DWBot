namespace DWBot.Domain.Entities.States;

public sealed class DesktopState : BaseState
{
    public override Guid Id => new("83CA9857-3BCA-47BF-B0CD-284E1D1E9E9D");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override DesktopStateView GetView()
    {
        return new DesktopStateView(this);
    }
}
