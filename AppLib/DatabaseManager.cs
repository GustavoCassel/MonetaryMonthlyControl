using AppLib.Properties;
using System.Data;
using System.Data.SqlClient;

/*
* SQL queries run in this order:
* 
* FROM + JOIN
* WHERE
* GROUP BY
* HAVING
* SELECT
* ORDER BY
* LIMIT
*/

namespace AppLib;

public static class DatabaseManager
{
    public const string LocalDBName = "MSSQLLocalDB";
    public const string DatabaseName = "MonetaryControl";
    public static string ShortConnectionString { get; }
    public static string FullConnectionString { get; }
    public static string AttachDBPath { get; } = "C:\\MonetaryControlDatabaseFiles";
    public static async Task<string> GetSqlStatementFromFile(string fileName)
    => await File.ReadAllTextAsync($"SQL-Commands\\{fileName}.sql");

    static DatabaseManager()
    {
        Directory.CreateDirectory(AttachDBPath);

        ShortConnectionString = $"Data Source=(LocalDB)\\{LocalDBName};";

        FullConnectionString = $"""
            {ShortConnectionString}
            Integrated Security = True
            """;
        //AttachDbFilename = {AttachDBPath}\{Resources.DatabaseName}.mdf;
    }

    public static async Task Main(CancellationToken cancellationToken)
    {
        string sql = await GetSqlStatementFromFile("CreateDatabase");

        using SqlConnection sqlConnection = new(FullConnectionString);
        await sqlConnection.OpenAsync(cancellationToken);
        await using SqlCommand cmd = new(sql, sqlConnection);
        // cmd.Parameters.AddWithValue("@teste", Resources.DatabaseName);
        await cmd.ExecuteNonQueryAsync(cancellationToken);

        using SqlDataAdapter dataAdapter = new(cmd);

        DataTable table = new();
        dataAdapter.Fill(table);

        foreach (DataRow row in table.Rows)
        {
            //Category category = new(row);

        }

        /*foreach (DataColumn column in table.Columns)
        {
            Debug.WriteLine(column.ColumnName);
            Debug.WriteLine(row[column]);
        }*/

        return;

        await CreateDatabase();
    }

    [Obsolete("Test Purposes")]
    private static async Task DeleteDatabase()
    {
        const string sql = "DROP DATABASE IF EXISTS [@Database]";

        using SqlConnection connection = new(ShortConnectionString);
        connection.Open();

        using SqlCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Database", DatabaseName);

        await command.ExecuteNonQueryAsync();
    }

    private static async Task CreateDatabase()
    {
        string sql = $"""
            IF NOT EXISTS
            (
                SELECT name
                FROM sys.databases
                WHERE name = '{Resources.DatabaseName}'
            )
            CREATE DATABASE {Resources.DatabaseName}
            ON PRIMARY
            (
                NAME = {Resources.DatabaseName},
                FILENAME = '{AttachDBPath}\{Resources.DatabaseName}.mdf'
            )
            LOG ON
            (
                NAME = {Resources.DatabaseName}_log,
                FILENAME = '{AttachDBPath}\{Resources.DatabaseName}_log.ldf'
            );
            """;

        using SqlConnection connection = new(ShortConnectionString);
        connection.Open();

        using SqlCommand command = new(sql, connection);

        await command.ExecuteNonQueryAsync();
    }
}