namespace DWBot.Services.StateMachine.States;

internal abstract class BaseState
{
    public virtual void OnEntry() { }
    public virtual void OnExit() { }
    public readonly HashSet<BotStates> Transitions;
    public abstract BotStates State { get; }

    protected StateConfig Config { get; }
    protected abstract HashSet<BotStates> GetTransitions();
    protected abstract StateConfig GetConfig();
 
    public BaseState()
    {
        Transitions = GetTransitions();
        Config = GetConfig();
    }
}
