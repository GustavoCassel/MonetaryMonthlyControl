using System.Data.SqlClient;

namespace AppLib;

public static class DBGlobal
{
    public static async Task<string> GetSqlStatementFromFile(string fileName)
        => await File.ReadAllTextAsync($"SQL-Commands\\{fileName}.sql");

    private static SqlConnection myVar;

    public static SqlConnection LocalDBConnection
    {
        get => myVar;
        set
        {
            myVar = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    //public static SqlConnection LocalDBConnection { get; private set; }
    public static void SetSqlConnection()
    {
        LocalDBConnection = new SqlConnection("")
            ?? throw new Exception();
    }

    public static void OpenConnection()
    {
        LocalDBConnection?.Open();
    }

    public static void CloseConnection()
    {
        LocalDBConnection?.Close();
    }
}