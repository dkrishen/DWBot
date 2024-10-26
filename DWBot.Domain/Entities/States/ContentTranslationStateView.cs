namespace DWBot.Domain.Entities.States;

public sealed class ContentTranslationStateView : BaseView
{
    public ContentTranslationStateView(ContentTranslationState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Контент для глобальных рынков"
                                      
                                      Перевод и адаптация контента для IT-компаний, таких как статьи, блоги, маркетинговые материалы, пресс-релизы, и презентации для международной аудитории.
                                      """;
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}