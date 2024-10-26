namespace DWBot.Domain.Entities.States;

public class AutomationStateView : BaseView
{
    public AutomationStateView(AutomationState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Автоматизация процессов" 🔄
                                      
                                      Наши решения помогут вам автоматизировать бизнес-процессы, экономя время и ресурсы.
                                      """;
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}