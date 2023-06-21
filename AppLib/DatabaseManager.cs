using AppLib.Properties;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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
    private static string ShortConnectionString { get; }
    private static string FullConnectionString { get; }
    private static string AttachDBPath { get; } = "C:\\MonetaryControlDatabaseFiles";

    static DatabaseManager()
    {
        Directory.CreateDirectory(AttachDBPath);

        ShortConnectionString = $"Data Source=(LocalDB)\\{Resources.SqlLocalDBName};";

        FullConnectionString = $"""
            {ShortConnectionString}
            AttachDbFilename = {AttachDBPath}\{Resources.DatabaseName}.mdf;
            Integrated Security = True
            """;
    }

    public static async Task Main()
    {
        string sql = await DBGlobal.GetSqlStatementFromFile("CreateDatabase");

        using SqlConnection sqlConnection = new(FullConnectionString);
        sqlConnection.Open();
        using SqlCommand cmd = new(sql, sqlConnection);
        // cmd.Parameters.AddWithValue("@teste", Resources.DatabaseName);
        await cmd.ExecuteNonQueryAsync();

        using SqlDataAdapter dataAdapter = new(cmd);

        DataTable table = new();
        dataAdapter.Fill(table);

        foreach (DataRow row in table.Rows)
        {
            Category category = new(row);

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
        command.Parameters.AddWithValue("@Database", Resources.DatabaseName);

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

    private static async Task CreateTable(string tableName)
    {
        const string sql = $"""
            USE @Database
            IF NOT EXISTS
            (
                SELECT TABLE_NAME
                FROM @Database.INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_NAME = '@TableName'
            )
            BEGIN
            CREATE TABLE [@TableName]
            (
                [Id] INT NOT NULL IDENTITY(1,1),
                [Description] VARCHAR(128) NOT NULL,
                [Amount] DECIMAL(9,2) NOT NULL,
                PRIMARY KEY (Id)
            )
            END;
            """;

        /*ALTER TABLE {tableName}
        ADD [Teste] INT NOT NULL
        ";*/

        using SqlConnection connection = new(FullConnectionString);
        connection.Open();

        using SqlCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Database", Resources.DatabaseName);
        command.Parameters.AddWithValue("@TableName", tableName);

        await command.ExecuteNonQueryAsync();
    }
}