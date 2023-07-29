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
            Application.Run(new FormMenu());
        }
        catch (Exception ex)
        {
            UserMessage.ShowError(ex.Message, Level.FatalError);
        }
    }
}