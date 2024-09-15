namespace DWBot.Services.StateMachine.States;

internal class WebState : BaseState
{
    public override BotStates State => BotStates.Web;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("web");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.ChatWithManager,
            BotStates.Apply,
            BotStates.Back,
        };

        return transitions;
    }

    public override void OnEntry()
    {
        base.OnEntry();
    }
}
