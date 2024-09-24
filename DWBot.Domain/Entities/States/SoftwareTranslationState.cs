namespace DWBot.Domain.Entities.States;

public sealed class SoftwareTranslationState : BaseState
{
    public override Guid Id => new("80C805ED-1C8A-4B38-8713-CF3048A8D473");
    public override string Description => "Вы выбрали \"Локализация приложений\"\r\n\r\nПеревод интерфейсов приложений, программ, веб-сайтов с учетом культурных и языковых особенностей целевой аудитории, а также SEO-текстов, оптимизированных для поисковых систем разных стран.";
    public override (string, string) ButtonConfig
        => ("Локализация приложений", "/software-translation");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
