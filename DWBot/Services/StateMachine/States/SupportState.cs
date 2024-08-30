namespace DWBot.Services.StateMachine.States;

internal class SupportState : BaseState
{
    public override BotStates State => BotStates.Support;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("support");
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
