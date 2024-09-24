namespace DWBot.Domain.Entities.States;

public sealed class TextTranslationState : BaseState
{
    public override Guid Id => new("191AD54E-FBD6-4A54-84D8-F1B2A3651446");
    public override string Description => "Вы выбрали \"Технический перевод\"\r\n\r\nПеревод технической документации для программного обеспечения, устройств, оборудования, инструкций для пользователей, API-документации и руководств по разработке.\r\nПоддержка разработчиков в переводе внутренних и внешних технических описаний, баг-репортов, спецификаций.";
    public override (string, string) ButtonConfig
        => ("Технический перевод", "/text-translation");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
