namespace DWBot.Domain.Entities.States;

public sealed class SoftwareTranslationStateView : BaseView
{
    public SoftwareTranslationStateView(SoftwareTranslationState state) : base(state)
    {
    }

    public override string Message => "Вы выбрали \"Локализация приложений\"\r\n\r\nПеревод интерфейсов приложений, программ, веб-сайтов с учетом культурных и языковых особенностей целевой аудитории, а также SEO-текстов, оптимизированных для поисковых систем разных стран.";
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}