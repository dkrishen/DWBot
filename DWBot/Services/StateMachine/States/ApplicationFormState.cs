namespace DWBot.Services.StateMachine.States;

internal class ApplicationFormState : BaseState
{
    public override BotStates State => BotStates.ApplicationForm;

    protected override StateConfig GetConfig()
    {
        var config = new StateConfig("application form");
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
