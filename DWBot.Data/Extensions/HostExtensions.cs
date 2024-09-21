using DWBot.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DWBot.Data.Extensions;

public static class HostExtensions
{
    public static void ExecuteDataLayerInitializationActions(this IHost host)
    {
        SQLiteHelper.EnsureDatabaseFileCreated(SQLiteDbContext.FileName);
        EnsureAllStateIdsAreUnique();

        {
            using var scope = host.Services.CreateScope();

            var context = scope.ServiceProvider.GetService<SQLiteDbContext>()
                ?? throw new Exception("Unable to create an instance of context!");

            context.EnableSQLiteWalMode();
            context.Database.Migrate();
        }
    }

    private static void EnsureAllStateIdsAreUnique()
    {
        if (StateRepository.AvailableStates.Keys.Distinct().Count() != StateRepository.AvailableStates.Count)
            throw new Exception("Unable to launch the application. Not all states are unique");
    }
}
