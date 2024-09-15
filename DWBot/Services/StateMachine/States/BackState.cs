namespace DWBot.Services.StateMachine.States;

internal class BackState : BaseState
{
    public override BotStates State => BotStates.Back;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("back");
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

    public override void OnExit()
    {
        base.OnExit();
    }
}
