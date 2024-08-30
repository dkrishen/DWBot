namespace DWBot.Services.StateMachine.States;

internal class StartState : BaseState
{
    public override BotStates State { get => BotStates.Start; }

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("start");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.SoftwareDevelopment,
            BotStates.Consulting,
            BotStates.Support,
            BotStates.FAQ
        };

        return transitions;
    }
}
