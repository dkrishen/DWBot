namespace DWBot.Domain.Entities.States;

public sealed class TranslationState : BaseState
{
    public override Guid Id => new("A2CAE257-6A38-457D-84BC-7666C485C4C7");
    public override string Description => "Вы выбрали \"Локализация\" 🇺🇸🇨🇳\r\n\r\nЛокализация — это не просто перевод, а адаптация вашего продукта под культурные, языковые и технические особенности целевой аудитории. Мы предлагаем услуги профессиональной локализации программного обеспечения, веб-сайтов, мобильных приложений, а также маркетингового и технического контента на английский и китайский языки.";
    public override (string, string) ButtonConfig
        => ("Локализация", "/translation");
    public override string MenuConfig => "Выберите, какая услуга вас интересует:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof (SoftwareTranslationState),
        typeof (TextTranslationState),
        typeof (ContentTranslationState),
        typeof (StartState),
    ];
}
