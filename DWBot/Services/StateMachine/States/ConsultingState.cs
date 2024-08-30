namespace DWBot.Services.StateMachine.States;

internal class ConsultingState : BaseState
{
    public override BotStates State => BotStates.Consulting;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("consalting state");
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
