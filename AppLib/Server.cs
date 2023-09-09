using AppLib.Models;
using Bogus;

namespace AppLib;

public static class Server
{
    private static readonly Faker _faker = new("pt_BR");

    public async static Task StartDatabase(CancellationToken cancellationToken)
    {
        using DataContext context = new();
        await context.Database.EnsureCreatedAsync(cancellationToken);
    }

    public async static Task DropDatabase(CancellationToken cancellationToken)
    {
        using DataContext context = new();
        await context.Database.EnsureDeletedAsync(cancellationToken);
    }

    public async static Task FulfillFakeData(CancellationToken cancellationToken)
    {
        using DataContext context = new();

        const int NumberOfFakeCategories = 20;
        for (int i = 0; i < NumberOfFakeCategories; i++)
        {
            string name = _faker.Name.FullName();
            if (name.Length > 20)
                name = name[..20];

            context.Categories.Add(new Category()
            {
                Name = name,
                Description = string.Join(" ", _faker.Lorem.Words(5))
            });

            //context.Entries.Add(new Entry());
        }

        await context.SaveChangesAsync(cancellationToken);
    }
}