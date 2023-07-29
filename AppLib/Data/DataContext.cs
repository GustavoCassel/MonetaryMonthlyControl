using Microsoft.EntityFrameworkCore;

namespace AppLib.Data;

public sealed class DataContext : DbContext
{
    public const string ConnectionString = $"""
        Server=(LocalDB)\MSSQLLocalDB;
        Database=MonetaryControl;
        Integrated Security = True;
        Trusted_Connection=True;
        """;

    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(ConnectionString);
    }
}