namespace DWBot.Services.StateMachine.States;

internal class ChatWithManagerState : BaseState
{
    public override BotStates State => BotStates.ChatWithManager;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("chat with manager");
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

        // redirect to chat
    }
}
