namespace DWBot.Domain.Entities.States;

public class AutomationState : BaseState
{
    public override Guid Id => new("E62977E6-B54F-469E-AA1A-6CB42998BD4C");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];

    public override AutomationStateView GetView()
    {
        return new AutomationStateView(this);
    }
}
