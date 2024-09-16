using DWBot.Services.StateMachine.States;

namespace DWBot.Services.StateMachine;

internal class BotStateMachine
{
    public BaseState Condition { get; private set; }

    public BotStateMachine()
    {
        Condition = new StartState();
    }

    public BotStateMachine(BaseState state)
    {
        Condition = state;
    }

    public bool MoveTo(BotStates trigger)
    {
        if (!Condition.Transitions.Contains(trigger))
            return false;

        if (BotStateConfiguration.States.TryGetValue(trigger, out var nextState))
        {
            Condition.OnExit();
            Condition = nextState;
            Condition.OnEntry();

            return true;
        }

        return false;
    }
}
