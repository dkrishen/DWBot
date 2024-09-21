using DWBot.Domain.Entities.States;

namespace DWBot.Domain.Repositories;

public interface IStateRepository
{
    Task SetUserStateAsync(long userId, BaseState state, CancellationToken ct = default);
    public Task<BaseState> GetUserStateAsync(long userId, CancellationToken ct = default);
}
