namespace DWBot.Domain.Entities.States;

public sealed class ApplyState : BaseState
{
    public override Guid Id => new("80D442BB-A702-42CA-AAFB-E702B7CFC211");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override ApplyStateView GetView()
    {
        return new ApplyStateView(this);
    }
}
