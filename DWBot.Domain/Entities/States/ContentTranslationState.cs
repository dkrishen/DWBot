namespace DWBot.Domain.Entities.States;

public sealed class ContentTranslationState : BaseState
{
    public override Guid Id => new("0775028D-B055-42ED-85B4-259E97D30046");
    public override string Description => "Вы выбрали \"Контент для глобальных рынков\"\r\n\r\nПеревод и адаптация контента для IT-компаний, таких как статьи, блоги, маркетинговые материалы, пресс-релизы, и презентации для международной аудитории.";
    public override (string, string) ButtonConfig
        => ("Контент для глобальных рынков", "/content-translation");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
