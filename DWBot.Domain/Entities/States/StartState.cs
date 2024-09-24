namespace DWBot.Domain.Entities.States;

public sealed class StartState : BaseState
{
    public override Guid Id => new("9C4F60B3-9F35-44C0-ACB8-C364FC5DE7CF");
    public override string Description => "Привет! 👋  \r\nСпасибо, что выбрали нас. Мы предлагаем широкий выбор IT-услуг и готовы помочь вам с любыми задачами.";
    public override (string, string) ButtonConfig
        => ("Вернуться на главную", "/start");
    public override string MenuConfig => "Пожалуйста, выберите услугу, которая вас интересует:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(SoftwareDevelopmentState),
        typeof(DesingState),
        typeof(ConsultingState),
        typeof(TranslationState),
        typeof(SupportState),
        typeof(PriceState),
        typeof(FAQState),
    ];
}
