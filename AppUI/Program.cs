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

        Bogus.Faker faker = new("pt_BR");

        using var context = new DataContext();

        context.Database.EnsureCreated();

        for (int i = 0; i < 20; i++)
        {
            string name = faker.Name.FullName();
            if (name.Length > 20)
                name = name[..20];

            context.Categories.Add(new Category()
            {
                Name = name,
                Description = string.Join(" ", faker.Lorem.Words(5))
            });

            //context.Entries.Add(new Entry());
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