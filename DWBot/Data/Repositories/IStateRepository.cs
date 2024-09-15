using DWBot.Services.StateMachine.States;

namespace DWBot.Data.Repositories;

internal interface IStateRepository
{
    Task SetUserStateAsync(long userId, BaseState state);
    public Task<BaseState> GetUserStateAsync(long userId);
}
