namespace DWBot.Data;

internal static class SQLiteHelper
{
    public static void EnsureDatabaseFileCreated(string sqliteFilePath)
    {
        if (!File.Exists(sqliteFilePath))
        {
            string directoryPath = Path.GetDirectoryName(sqliteFilePath)
                ?? throw new Exception("Unable to extract directory name from DB file path!");

            Directory.CreateDirectory(directoryPath);

            using var _ = File.Create(sqliteFilePath);
        }
    }
}
