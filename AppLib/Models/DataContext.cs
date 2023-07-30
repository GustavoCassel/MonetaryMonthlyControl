using Microsoft.EntityFrameworkCore;

namespace AppLib.Models;

public sealed class DataContext : DbContext
{
    public const string ConnectionString = $"""
        Server=(LocalDB)\MSSQLLocalDB;
        Database=MonetaryControl;
        Integrated Security = True;
        Trusted_Connection=True;
        """;

    public DbSet<Category> Categories { get; set; }
    public DbSet<Entry> Entries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07F351CB07");

            entity.HasIndex(e => e.Name, "UQ__Categori__737584F6F48DD4E2").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(128);
        });

        modelBuilder.Entity<Entry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Entries__3214EC07E0F5CAE5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Amount).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Entries)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Entries__Categor__412EB0B6");
        });
    }
}