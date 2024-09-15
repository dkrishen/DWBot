using DWBot.Services.StateMachine.States;

namespace DWBot.Services.StateMachine;

internal class BotStateMachine
{
    private BaseState Condition;

    public BotStateMachine()
    {
        Condition = new StartState();
    }

    public BotStateMachine(BaseState state)
    {
        Condition = state;
    }

    public void MoveTo(BotStates trigger)
    {
        if (!Condition.Transitions.Contains(trigger))
            return;

        if (BotStateConfiguration.States.TryGetValue(trigger, out var nextState))
        {
            Condition.OnExit();
            Condition = nextState;
            Condition.OnEntry();
        }
    }
}
