﻿using DWBot.Domain.Entities.States;
using DWBot.Domain.Repositories;

namespace DWBot.Data.Repositories;

public sealed class InMemoryStateRepository : IStateRepository
{
    private static Dictionary<long, BaseState> data = new Dictionary<long, BaseState>();

    public Task SetUserStateAsync(long userId, BaseState state)
    {
        if (data.Keys.Contains(userId))
            data[userId] = state;
        else
            data.Add(userId, state);

        return Task.CompletedTask;
    }

    public Task<BaseState> GetUserStateAsync(long userId)
    {
        if (data.Keys.Contains(userId))
            return Task.FromResult(data[userId]);

        return Task.FromResult<BaseState>(new NoneState());
    }
}