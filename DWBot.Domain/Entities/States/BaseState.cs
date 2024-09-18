namespace DWBot.Domain.Entities.States;

public abstract class BaseState
{
    public HashSet<Type> Transitions { get; } = [];
    public abstract string Description { get; }
    public abstract (string, string) ButtonConfig { get; }
    public abstract string MenuConfig { get; }

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

    public List<(string, string)> GetMenu()
    {
        var buttonConfigs = Transitions
            .Select(stateType => (BaseState)Activator.CreateInstance(stateType))
            .Select(state => state.ButtonConfig)
            .ToList();

        return buttonConfigs;
    }

    public string GetMessage() => Description;
}
