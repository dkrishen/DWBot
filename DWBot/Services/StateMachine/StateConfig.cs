namespace DWBot.Services.StateMachine;

internal class StateConfig
{
    public string Description { get; private set; }

    public StateConfig(string description)
    {
        Description = description;
    }
}
