namespace DWBot.Domain.Entities.States;

public sealed class ConsultingState : BaseState
{
    public override Guid Id => new("C45450BF-2A2A-4F50-A2E9-FED791EBA13D");
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
