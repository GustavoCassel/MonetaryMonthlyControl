using System.Data.SqlClient;

namespace AppLib;

public static class Global
{
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
        LocalDBConnection = new SqlConnection(DatabaseManager.FullConnectionString)
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