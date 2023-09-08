using AppLib;

namespace AppUI;

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

        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormConfigurations());
        }
        finally
        {
#if DEBUG
            Server.DropDatabase(new CancellationToken()).Wait();
#endif
        }
    }
}