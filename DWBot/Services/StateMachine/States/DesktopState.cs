namespace DWBot.Services.StateMachine.States;

internal class DesktopState : BaseState
{
    public override BotStates State => BotStates.Desktop;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("desktop");
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
