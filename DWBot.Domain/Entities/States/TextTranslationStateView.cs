namespace DWBot.Domain.Entities.States;

public sealed class TextTranslationStateView : BaseView
{
    public TextTranslationStateView(TextTranslationState state) : base(state)
    {
    }

    public override string Message => "Вы выбрали \"Технический перевод\"\r\n\r\nПеревод технической документации для программного обеспечения, устройств, оборудования, инструкций для пользователей, API-документации и руководств по разработке.\r\nПоддержка разработчиков в переводе внутренних и внешних технических описаний, баг-репортов, спецификаций.";
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}