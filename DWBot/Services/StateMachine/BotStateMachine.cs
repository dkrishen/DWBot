using DWBot.Services.StateMachine.States;

namespace DWBot.Services.StateMachine;

internal sealed class BotStateMachine
{
    public BaseState CurrentState { get; private set; }

    public BotStateMachine()
    {
        CurrentState = new StartState();
    }

    public BotStateMachine(BaseState state)
    {
        CurrentState = state;
    }

    public bool MoveTo(Type target)
    {
        if (target is null || !target.IsSubclassOf(typeof(BaseState)))
            return false;

        var newStateObject = Activator.CreateInstance(target)
            ?? throw new Exception("Unable to create an instance of the state");

        CurrentState.OnExit();
        CurrentState = (BaseState)newStateObject;
        CurrentState.OnEntry();

        return true;
    }
}
