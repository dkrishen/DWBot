namespace DWBot.Domain.Entities.States;

public sealed class ConsultingState : BaseState
{
    public override string Description => "Вы выбрали \"Консалтинг\" 📊\r\n\r\nНаши эксперты помогут вам оптимизировать бизнес-процессы и внедрить передовые технологии для повышения эффективности вашей компании.";
    public override (string, string) ButtonConfig
        => ("Консалтинг", "/consulting");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
