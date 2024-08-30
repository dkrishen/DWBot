namespace DWBot.Services.StateMachine.States;

internal class BotsState : BaseState
{
    public override BotStates State => BotStates.Bots;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("bot");
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
        HelpingState = this;
        base.OnEntry();
    }
}
