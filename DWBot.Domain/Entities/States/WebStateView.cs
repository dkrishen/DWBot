namespace DWBot.Domain.Entities.States;

public sealed class WebStateView : BaseView
{
    public WebStateView(WebState state) : base(state)
    {
    }

    public override string Message => "Вы выбрали \"Веб-разработка\" 🌐\r\n\r\nМы создадим для вас профессиональный сайт, соответствующий последним стандартам UX/UI.";
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}