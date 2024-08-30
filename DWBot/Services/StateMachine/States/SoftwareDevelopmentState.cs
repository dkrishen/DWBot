namespace DWBot.Services.StateMachine.States;

internal class SoftwareDevelopmentState : BaseState
{
    public override BotStates State => BotStates.SoftwareDevelopment;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("software");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.Web,
            BotStates.Desktop,
            BotStates.Bots,
            BotStates.Automation
        };

        return transitions;
    }
}
