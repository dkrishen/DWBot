using DWBot.Domain.Entities.States;

namespace DWBot.Domain.Repositories;

public interface IStateRepository
{
    Task SetUserStateAsync(long userId, BaseState state);
    public Task<BaseState> GetUserStateAsync(long userId);
}
