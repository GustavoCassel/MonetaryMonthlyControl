using System.Data.SqlClient;
using System.Reflection;

namespace AppLib;

public static class DBGlobal
{
    public static async Task<string> GetSqlStatement(string fileName)
    {
        string fullPath = $"SQL-Commands\\{fileName}.sql";

        if (File.Exists(fullPath))
        {

        }

        return await File.ReadAllTextAsync(fullPath);
    }

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