using Microsoft.EntityFrameworkCore;

namespace AppLib.Data;

public sealed class DataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(DatabaseManager.FullConnectionString);
    }
}