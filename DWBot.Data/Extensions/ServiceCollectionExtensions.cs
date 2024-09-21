using DWBot.Data.Repositories;
using DWBot.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DWBot.Data.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterDataLayerDependencies(this IServiceCollection services)
    {
        services.AddDbContext<SQLiteDbContext>(optionsBuilder =>
        {
            optionsBuilder.UseSqlite(
                connectionString: SQLiteDbContext.ConnectionString,
                sqliteOptions =>
                {
                    sqliteOptions.CommandTimeout(10);
                });

#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif
        });

        services.AddScoped<IStateRepository, StateRepository>();
    }
}
