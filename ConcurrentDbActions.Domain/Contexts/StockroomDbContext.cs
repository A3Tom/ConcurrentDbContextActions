using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrentDbActions.Domain.Contexts
{
    public class StockroomDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<PriceAudit> PriceHistory { get; set; }
        public DbSet<StockAudit> StockHistory { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(StockroomDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
