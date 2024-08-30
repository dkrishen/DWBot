namespace DWBot.Services.StateMachine.States;

internal class ApplyState : BaseState
{
    public override BotStates State => BotStates.Apply;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("apply");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.ApplicationForm
        };

        return transitions;
    }
}
