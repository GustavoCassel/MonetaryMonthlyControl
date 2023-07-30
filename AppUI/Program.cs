using AppLib.Models;

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

        using var context = new DataContext();

        context.Database.EnsureCreated();

        for (int i = 0; i < 10; i++)
        {
            context.Categories.Add(new Category());
            context.Entries.Add(new Entry());
        }

        context.SaveChanges();

        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());
        }
        catch (Exception ex)
        {
            UserMessage.ShowError(ex.Message, Level.FatalError);
        }
        finally
        {
            context.Database.EnsureDeleted();
        }
    }
}