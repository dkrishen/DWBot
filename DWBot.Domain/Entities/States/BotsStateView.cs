namespace DWBot.Domain.Entities.States;

public sealed class BotsStateView : BaseView
{
    public BotsStateView(BotsState state) : base(state)
    {
    }

    public override string Message => "Вы выбрали \"Разработка ботов\" 🤖\r\n\r\nМы создаем интеллектуальных ботов, которые помогут вам автоматизировать общение с клиентами и улучшить сервис.";
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}