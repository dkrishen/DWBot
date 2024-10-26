namespace DWBot.Domain.Entities.States;

public sealed class StartState : BaseState
{
    public override Guid Id => new("9C4F60B3-9F35-44C0-ACB8-C364FC5DE7CF");

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(SoftwareDevelopmentState),
        typeof(DesignState),
        typeof(ConsultingState),
        typeof(TranslationState),
        typeof(SupportState),
        typeof(PriceState),
        typeof(FAQState),
    ];

    public override StartStateView GetView()
    {
        return new StartStateView(this);
    }
}
