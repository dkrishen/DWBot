namespace DWBot.Domain.Entities.States;

public sealed class DesingState : BaseState
{
    public override Guid Id => new("42ABDDF5-069C-4858-9DF4-321CE5F06BDD");
    public override string Description => "Вы выбрали \"Дизайн\" 🎨\r\n\r\nНаши дизайнеры создадут уникальный и привлекательный дизайн для вашего проекта, который подчеркнет его индивидуальность.";
    public override (string, string) ButtonConfig
        => ("Дизайн", "/design");
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(ChatWithManagerState),
        typeof(ApplyState),
        typeof(StartState),
    ];
}
