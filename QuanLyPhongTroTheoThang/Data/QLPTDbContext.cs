using System.Configuration;
using Microsoft.EntityFrameworkCore;
using QuanLyPhongTroTheoThang.Data;

public class QLPTDbContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Bill> Bills { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            ConfigurationManager.ConnectionStrings["QLPTConnection"].ConnectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Contract>()
            .Property(p => p.Deposit)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Bill>()
            .Property(p => p.Total)
            .HasPrecision(18, 2);
    }
}