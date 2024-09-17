namespace DWBot.Domain.Entities.States;

public abstract class BaseState
{
    public HashSet<Type> Transitions { get; } = [];
    public abstract string Description { get; }

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

    public abstract void OnEntry();
    public abstract void OnExit();
    protected abstract IEnumerable<Type> GetTransitions();

    public List<string> GetMenu()
    {
        var list = Transitions
            .Select(stateType => stateType.Name.Replace("State", ""))
            .ToList();

        return list;
    }

    public string GetMessage() => Description;
}
