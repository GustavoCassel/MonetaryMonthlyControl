using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryMonthlyControl.DatabaseMaintenance
{
    public class DatabaseManager
    {
        private const string SqlLocalDBName = "MSSQLLocalDB";
        private const string DatabaseName = "MyDatabase";

        private static string GetConnectionString()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            return $"Data Source = (LocalDB)\\{SqlLocalDBName};" +
            $"AttachDbFilename = {currentDirectory}\\{DatabaseName}.mdf;" +
            "Integrated Security = True";
        }

        public static async void DeleteDatabase()
        {
            string sql = $"DROP DATABASE IF EXISTS [{DatabaseName}]";

            using SqlConnection connection = new($"Data Source=(LocalDB)\\{SqlLocalDBName};");
            connection.Open();

            using SqlCommand command = new(sql, connection);
            await command.ExecuteNonQueryAsync();

            command.Dispose();
            connection.Close();
        }

        public static async void CreateDatabase()
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

            using SqlConnection connection = new($"Data Source=(LocalDB)\\{SqlLocalDBName};");
            connection.Open();

            using SqlCommand command = new(sql, connection);
            await command.ExecuteNonQueryAsync();

            command.Dispose();
            connection.Close();
        }

        public static async void CreateTables()
        {
            string sql = $@"
                IF NOT EXISTS
                (
                    SELECT TABLE_NAME
                    FROM {DatabaseName}.INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME = 'January'
                )
                BEGIN
                CREATE TABLE January
                (
                    id int NOT NULL IDENTITY(1,1),
                    description varchar(128) NOT NULL,
                    amount decimal(9,2) NOT NULL,
                    PRIMARY KEY (id)
                )
                END;";

            using SqlConnection connection = new(GetConnectionString());
            connection.Open();

            using SqlCommand command = new(sql, connection);
            await command.ExecuteNonQueryAsync();

            command.Dispose();
            connection.Close();
        }
    }
}