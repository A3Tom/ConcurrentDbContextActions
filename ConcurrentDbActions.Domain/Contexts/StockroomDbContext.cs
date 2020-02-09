using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrentDbActions.Domain.Contexts
{
    public class StockroomDbContext : DbContext
    {
        public StockroomDbContext()
        {
        }

        public StockroomDbContext(DbContextOptions options) : 
            base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<PriceAudit> PriceHistory { get; set; }
        public DbSet<StockAudit> StockHistory { get; set; } 
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JGPE91F\\SQLEXPRESS;Initial Catalog=Stockroom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(StockroomDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
