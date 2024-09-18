namespace DWBot.Domain.Entities.States;

public class AutomationState : BaseState
{
    public override string Description => "Вы выбрали \"Автоматизация процессов\" 🔄\r\n\r\nНаши решения помогут вам автоматизировать бизнес-процессы, экономя время и ресурсы.";
    public override (string, string) ButtonConfig
        => ("Автоматизация процессов", "/automation");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
