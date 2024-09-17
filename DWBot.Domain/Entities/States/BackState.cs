namespace DWBot.Domain.Entities.States;

public sealed class BackState : BaseState
{
    public override string Description => "back";

    protected override IEnumerable<Type> GetTransitions() =>
    [
        typeof(StartState),
    ];

    public override void OnEntry() { }
    public override void OnExit() { }
}
