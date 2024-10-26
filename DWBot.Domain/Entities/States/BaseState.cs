namespace DWBot.Domain.Entities.States;

public abstract class BaseState
{
    public abstract Guid Id { get; }
    public HashSet<Type> Transitions { get; } = [];

    public BaseState()
    {
        foreach (var stateType in GetTransitions())
        {
            if (stateType is null)
                throw new Exception("Unable to register state type. It is null");

            if (!stateType.IsSubclassOf(typeof(BaseState)))
                throw new Exception($"Provided type is not a type of state. Type: {stateType.FullName}");

            Transitions.Add(stateType);
        }
    }

    public virtual void OnEntry() { }
    public virtual void OnExit() { }
    protected abstract IEnumerable<Type> GetTransitions();
    
    public abstract IView GetView();
}
