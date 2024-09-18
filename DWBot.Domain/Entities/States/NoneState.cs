namespace DWBot.Domain.Entities.States;

public sealed class NoneState : BaseState
{
    public override string Description => "Кажется, я не знаю такой команды 👀";
    public override (string, string) ButtonConfig
        => ("", "/start");
    public override string MenuConfig => "Назад:";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];
}
