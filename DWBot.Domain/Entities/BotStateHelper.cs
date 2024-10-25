using DWBot.Domain.Entities.States;

namespace DWBot.Domain.Entities;

public static class BotStateHelper
{
    public static BaseState? TransitTo(BaseState currentState, Type target)
    {
        if (!target.IsSubclassOf(typeof(BaseState)))
            return null;

        var newStateObject = Activator.CreateInstance(target)
            ?? throw new Exception("Unable to create an instance of the state");

        currentState.OnExit();
        var targetState = (BaseState)newStateObject;
        targetState.OnEntry();

        return targetState;
    }
}
