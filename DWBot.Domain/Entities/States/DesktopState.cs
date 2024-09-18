namespace DWBot.Domain.Entities.States;

public sealed class DesktopState : BaseState
{
    public override string Description => "Вы выбрали \"Разработка десктопных приложений\" 🖥\r\n\r\nНаши решения помогут вам автоматизировать задачи и улучшить производительность вашего бизнеса.";
    public override (string, string) ButtonConfig
        => ("Разработка десктопных приложений", "/desktop");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
