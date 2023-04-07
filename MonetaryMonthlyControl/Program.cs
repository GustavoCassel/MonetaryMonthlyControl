using MonetaryMonthlyControl.DatabaseConnection;

namespace MonetaryMonthlyControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DatabaseManager.CreateDatabase();
            DatabaseManager.CreateTables();

            Application.Run(new Form1());
        }
    }
}