namespace DWBot.Services.StateMachine.States;

internal class NoneState : BaseState
{
    public override BotStates State { get => BotStates.Start; }

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("none");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.Start
        };

        return transitions;
    }
}
