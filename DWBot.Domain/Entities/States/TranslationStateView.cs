namespace DWBot.Domain.Entities.States;

public sealed class TranslationStateView : BaseView
{
    public TranslationStateView(TranslationState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Локализация" 🇺🇸🇨🇳
                                      
                                      Локализация — это не просто перевод, а адаптация вашего продукта под культурные, языковые и технические особенности целевой аудитории. Мы предлагаем услуги профессиональной локализации программного обеспечения, веб-сайтов, мобильных приложений, а также маркетингового и технического контента на английский и китайский языки.
                                      """;
    public override string MenuConfig => "Выберите, какая услуга вас интересует:";
}