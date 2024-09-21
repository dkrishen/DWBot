using DWBot.Data.EntitiesConfiguration;
using DWBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DWBot.Data;

internal sealed class SQLiteDbContext : DbContext
{
    public static string BaseDirectory { get; } = "";
    public static string Directory { get; } = Path.Combine(BaseDirectory, "database");
    public static string FileName { get; } = Path.Combine(Directory, "db.sqlite");
    public static string ConnectionString { get; } = $"Data Source={FileName}";

    private static readonly object _locker = new();

    public DbSet<UserState> UserStates => Set<UserState>();

    public SQLiteDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new StateConfiguration());
    }

    #region Async Methods Overrides

    // WARNING
    // SaveChangesAsync(...) must be overriden in case of SQLite database.
    // It allows us to use default Async methods BUT at the same time prevent parallel write access to the DB

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        lock (_locker)
        {
            return Task.FromResult(SaveChanges(acceptAllChangesOnSuccess));
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        lock (_locker)
        {
            return Task.FromResult(SaveChanges());
        }
    }

    #endregion
}
