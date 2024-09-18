namespace DWBot.Domain.Entities.States;

public sealed class ApplyState : BaseState
{
    public override string Description => "Оставьте заявку на заказ 📝\r\n\r\nhttps://forms.gle/uv62gVsAmNNdk3iUA";
    public override (string, string) ButtonConfig
        => ("Оставить заявку", "/apply");
    public override string MenuConfig => "Спасибо! Мы свяжемся с вами в течение 24 часов.";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];
}
