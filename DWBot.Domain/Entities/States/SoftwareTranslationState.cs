namespace DWBot.Domain.Entities.States;

public sealed class SoftwareTranslationState : BaseState
{
    public override Guid Id => new("80C805ED-1C8A-4B38-8713-CF3048A8D473");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override SoftwareTranslationStateView GetView()
    {
        return new SoftwareTranslationStateView(this);
    }
}
