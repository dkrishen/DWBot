namespace DWBot.Domain.Entities.States;

public sealed class ApplyStateView : BaseView
{
    public ApplyStateView(ApplyState state) : base(state)
    {
    }

    public override string Message => """
                                      Оставьте заявку на заказ 📝
                                      
                                      https://forms.gle/uv62gVsAmNNdk3iUA
                                      """;
    public override string MenuConfig => "Спасибо! Мы свяжемся с вами в течение 24 часов.";
}