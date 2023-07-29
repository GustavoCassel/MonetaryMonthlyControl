using Microsoft.EntityFrameworkCore;

namespace AppLib.Data;

public sealed class DataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        const string ConnectionString = $"""
            Server=(LocalDB)\{DatabaseManager.LocalDBName};
            Database={DatabaseManager.DatabaseName};
            Integrated Security = True;
            """;

        optionsBuilder.UseSqlServer(ConnectionString);
    }
}