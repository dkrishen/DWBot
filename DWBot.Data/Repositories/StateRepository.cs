using DWBot.Domain.Entities;
using DWBot.Domain.Entities.States;
using DWBot.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DWBot.Data.Repositories;

internal sealed class StateRepository : IStateRepository
{
    public static readonly IReadOnlyDictionary<Guid, BaseState> AvailableStates;

    static StateRepository()
    {
        var existingStatesList = new List<BaseState>{
            new ApplyState(),
            new AutomationState(),
            new BotsState(),
            new ChatWithManagerState(),
            new ConsultingState(),
            new PriceState(),
            new DesingState(),
            new DesktopState(),
            new FAQState(),
            new NoneState(),
            new SoftwareDevelopmentState(),
            new StartState(),
            new SupportState(),
            new WebState(),
        };

        AvailableStates = existingStatesList.ToDictionary(state => state.Id);
    }

    private readonly SQLiteDbContext _context;

    public StateRepository(SQLiteDbContext context)
    {
        _context = context;
    }

    public async Task<BaseState> GetUserStateAsync(long userId, CancellationToken ct = default)
    {
        var currentUserState = await _context.UserStates.SingleOrDefaultAsync(x => x.UserId == userId, ct);

        if (currentUserState is not null)
            return currentUserState.State;

        var defaultUserStage = new UserState(userId, new StartState());
        _context.UserStates.Add(defaultUserStage);
        await _context.SaveChangesAsync(ct);
        return defaultUserStage.State;
    }

    public async Task SetUserStateAsync(long userId, BaseState state, CancellationToken ct = default)
    {
        var existingUserState = await _context.UserStates.SingleOrDefaultAsync(x => x.UserId == userId, ct);

        if (existingUserState is null)
            _context.UserStates.Add(new UserState(userId, state));
        else
            existingUserState.UpdateState(state);

        await _context.SaveChangesAsync(ct);
    }
}
