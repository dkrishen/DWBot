namespace DWBot.Domain.Entities.States;

public sealed class StartState : BaseState
{
    public override Guid Id => new("9C4F60B3-9F35-44C0-ACB8-C364FC5DE7CF");
    public override string Description => "Привет! 👋\r\nМы рады, что вы обратились к нам. В нашей компании вы можете выбрать из широкого спектра IT-услуг.";
    public override (string, string) ButtonConfig
        => ("Вернутсья на главную", "/start");
    public override string MenuConfig => "Пожалуйста, выберите услугу, которая вас интересует:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(SoftwareDevelopmentState),
        typeof(DesingState),
        typeof(ConsultingState),
        typeof(SupportState),
        typeof(FAQState),
    ];
}
