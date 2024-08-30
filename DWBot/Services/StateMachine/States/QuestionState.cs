namespace DWBot.Services.StateMachine.States;

internal class QuestionState : BaseState
{
    public override BotStates State => BotStates.Question;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("question");
        return config;
    }

    protected override HashSet<BotStates> GetTransitions()
    {
        var transitions = new HashSet<BotStates>()
        {
            BotStates.FAQ
        };

        return transitions;
    }
}
