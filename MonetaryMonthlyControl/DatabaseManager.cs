using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryMonthlyControl.DatabaseConnection
{
    public class DatabaseManager
    {
        private const string SqlLocalDBName = "MSSQLLocalDB";
        private const string DatabaseName = "MyDatabase";

        private static string GetConnectionString()
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();

            return $"Data Source = (LocalDB)\\{SqlLocalDBName};" +
            $"AttachDbFilename = {currentDirectory}\\{DatabaseName}.mdf;" +
            "Integrated Security = True";
        }

        public static async void CreateDatabase()
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();

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

            using (SqlConnection connection = new SqlConnection($"Data Source=(LocalDB)\\{SqlLocalDBName};"))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    await command.ExecuteNonQueryAsync();
                    command.Dispose();
                }

                connection.Close();
            }
        }

        public static async void CreateTables()
        {
            string sql = $@"
                CREATE TABLE January
                (
                    id int NOT NULL IDENTITY(1,1),
                    description varchar(128) NOT NULL,
                    amount decimal(9,6) NOT NULL,
                    PRIMARY KEY (id)
                );";

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    await command.ExecuteNonQueryAsync();
                    command.Dispose();
                }

                connection.Close();
            }
        }
    }
}