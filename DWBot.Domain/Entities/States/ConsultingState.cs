namespace DWBot.Domain.Entities.States;

public sealed class ConsultingState : BaseState
{
    public override Guid Id => new("C45450BF-2A2A-4F50-A2E9-FED791EBA13D");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override ConsultingStateView GetView()
    {
        return new ConsultingStateView(this);
    }
}
