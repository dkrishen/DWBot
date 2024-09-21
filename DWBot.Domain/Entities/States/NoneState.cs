namespace DWBot.Domain.Entities.States;

public sealed class NoneState : BaseState
{
    public override Guid Id => new("373ED21C-DDE1-4E27-91A9-CD122AAF56FB");
    public override string Description => "Кажется, я не знаю такой команды 👀";
    public override (string, string) ButtonConfig
        => ("", "/start");
    public override string MenuConfig => "Назад:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];
}
