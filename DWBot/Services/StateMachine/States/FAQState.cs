namespace DWBot.Services.StateMachine.States;

internal class FAQState : BaseState
{
    public override BotStates State => BotStates.FAQ;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("fack you");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.Question,
            BotStates.Back
        };

        return transitions;
    }
}
