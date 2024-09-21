using DWBot.Domain.Entities.States;

namespace DWBot.Domain.Entities;

public sealed class UserState
{
    public Guid Id { get; } = Guid.NewGuid();
    public long UserId { get; private set; }
    public BaseState State { get; private set; }

    /// <summary>
    /// Entity Framework Core constructor
    /// </summary>
    private UserState() { }

    public UserState(long userId, BaseState state)
    {
        UserId = userId;
        State = state;
    }

    public void UpdateState(BaseState newState)
    {
        State = newState;
    }
}
