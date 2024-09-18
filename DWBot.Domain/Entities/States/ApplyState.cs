namespace DWBot.Domain.Entities.States;

public sealed class ApplyState : BaseState
{
    public override string Description => "Оставьте заявку на заказ 📝\r\n\r\nПожалуйста, оставьте свои данные, и наш специалист свяжется с вами в ближайшее время.\r\n\r\n*Это должна быть гугл фрма\r\nВаше имя: [ожидание ввода текста]\r\nКонтактный телефон: [ожидание ввода текста]\r\nE-mail: [ожидание ввода текста]\r\nКраткое описание проекта или вопрос (необязательно): [ожидание ввода текста]";
    public override (string, string) ButtonConfig
        => ("Оставить заявку", "/apply");
    public override string MenuConfig => "Спасибо! Мы свяжемся с вами в течение 24 часов.";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];
}
