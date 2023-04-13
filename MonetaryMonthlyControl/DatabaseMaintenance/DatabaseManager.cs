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

namespace MonetaryMonthlyControl.DatabaseMaintenance
{
    public class DatabaseManager
    {
        private const string SqlLocalDBName = "MSSQLLocalDB";
        private const string DatabaseName = "MyDatabase";

        private readonly string _fullConnectionString;
        private readonly string _shortConnectionString;

        public DatabaseManager()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            _shortConnectionString = $"Data Source=(LocalDB)\\{SqlLocalDBName};";

            _fullConnectionString = $"Data Source = (LocalDB)\\{SqlLocalDBName};" +
            $"AttachDbFilename = {currentDirectory}\\{DatabaseName}.mdf;" +
            "Integrated Security = True";
        }

        public void DeleteDatabase()
        {
            const string sql = $"DROP DATABASE IF EXISTS [{DatabaseName}]";

            SqlConnection connection = new(_shortConnectionString);
            connection.Open();

            SqlCommand command = new(sql, connection);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        public void CreateDatabase()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string sql = $@"
                    IF NOT EXISTS
                    (
                        SELECT name
                        FROM sys.databases
                        WHERE name = '{DatabaseName}'
                    )
                    CREATE DATABASE {DatabaseName}
                    ON PRIMARY
                    (
                        NAME = {DatabaseName},
                        FILENAME = '{currentDirectory}\{DatabaseName}.mdf'
                    )
                    LOG ON
                    (
                        NAME = {DatabaseName}_log,
                        FILENAME = '{currentDirectory}\{DatabaseName}_log.ldf'
                    );";

            SqlConnection connection = new(_shortConnectionString);
            connection.Open();

            SqlCommand command = new(sql, connection);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        public void CreateTable(string tableName)
        {
            string sql = $@"
                USE {DatabaseName}
                IF NOT EXISTS
                (
                    SELECT TABLE_NAME
                    FROM {DatabaseName}.INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME = '{tableName}'
                )
                BEGIN
                CREATE TABLE [{tableName}]
                (
                    [Id] INT NOT NULL IDENTITY(1,1),
                    [Description] VARCHAR(128) NOT NULL,
                    [Amount] DECIMAL(9,2) NOT NULL,
                    PRIMARY KEY (Id)
                )
                END;";
                    /*ALTER TABLE {tableName}
                    ADD [Teste] INT NOT NULL
                ";*/

            SqlConnection connection = new(_fullConnectionString);
            connection.Open();

            SqlCommand command = new(sql, connection);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }
    }
}