using AppLib.Models;
using Bogus;

namespace AppLib;

public static class Server
{
    public static DataContext DataContext { get; private set; }
    private static readonly Faker _faker = new("pt_BR");

    static Server()
    {
        DataContext = new();
    }

    public async static Task StartDatabase(CancellationToken cancellationToken)
        => await DataContext.Database.EnsureCreatedAsync(cancellationToken);

    public async static Task DropDatabase(CancellationToken cancellationToken)
        => await DataContext.Database.EnsureDeletedAsync(cancellationToken);

    public async static Task FulfillFakeData(CancellationToken cancellationToken)
    {
        const int NumberOfFakeCategories = 20;
        for (int i = 0; i < NumberOfFakeCategories; i++)
        {
            string name = _faker.Name.FullName();
            if (name.Length > 20)
                name = name[..20];

            DataContext.Categories.Add(new Category()
            {
                Name = name,
                Description = string.Join(" ", _faker.Lorem.Words(5))
            });

            //context.Entries.Add(new Entry());
        }

        await DataContext.SaveChangesAsync(cancellationToken);
    }
}