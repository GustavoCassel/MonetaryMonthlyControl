using AppLib;
using AppLib.Data;

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

        try
        {
            //context.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());
            /*
            for (int i = 0; i < 5; i++)
            {
                context.Categories.Add(new Category());
            }

            context.SaveChanges();*/
        }
        catch (Exception ex)
        {
            UserMessage.ShowError(ex.Message, Level.FatalError);
        }
        finally
        {
            //context.Database.EnsureDeleted();
        }
    }
}