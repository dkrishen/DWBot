namespace DWBot.Domain.Entities.States;

public sealed class DesktopState : BaseState
{
    public override Guid Id => new("83CA9857-3BCA-47BF-B0CD-284E1D1E9E9D");
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
