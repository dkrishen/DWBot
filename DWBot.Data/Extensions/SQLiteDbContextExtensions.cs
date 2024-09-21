using Microsoft.EntityFrameworkCore;

namespace DWBot.Data.Extensions;

internal static class SQLiteDbContextExtensions
{
    /// <summary>
    /// Enables WAL mode on SQLite DB. Learn more about WAL mode on https://www.sqlite.org/wal.html
    /// </summary>
    /// <param name="context"></param>
    public static void EnableSQLiteWalMode(this SQLiteDbContext context)
    {
        context.Database.ExecuteSqlRaw("PRAGMA journal_mode=WAL");
    }
}
