namespace DWBot.Domain.Entities.States;

public sealed class NoneState : BaseState
{
    public override string Description => "none";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
