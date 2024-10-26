namespace DWBot.Domain.Entities.States;

public sealed class DesktopStateView : BaseView
{
    public DesktopStateView(DesktopState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Разработка десктопных приложений" 🖥
                                      
                                      Наши решения помогут вам автоматизировать задачи и улучшить производительность вашего бизнеса.
                                      """;
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}