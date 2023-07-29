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

    public static async Task ConfigureEntireDatabase(CancellationToken cancellationToken)
    {
        /*
        string sql = await GetSqlStatementFromFile("CreateDatabase");

        using SqlConnection sqlConnection = new(FullConnectionString);
        await sqlConnection.OpenAsync(cancellationToken);
        await using SqlCommand cmd = new(sql, sqlConnection);
        // cmd.Parameters.AddWithValue("@teste", Resources.DatabaseName);
        await cmd.ExecuteNonQueryAsync(cancellationToken);

        using SqlDataAdapter dataAdapter = new(cmd);

        DataTable table = new();
        dataAdapter.Fill(table);
        */
    }
}