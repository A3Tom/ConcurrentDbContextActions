using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class StockConfig : BaseConfig<Stock>
    {
        public override void Configure(EntityTypeBuilder<Stock> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Stock)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Location)
                .WithMany(x => x.Stock)
                .HasForeignKey(x => x.LocationId);

            builder.HasOne(x => x.Warehouse)
                .WithMany(x => x.Stock)
                .HasForeignKey(x => x.WarehouseId);

            builder.HasData(SeedData());
        }

        private static Stock[] SeedData()
        {
            return new Stock[]
            {
                new Stock(1, 1, 1, 20, true) { Id = 1 },
                new Stock(2, 1, 1, 8, true) { Id = 2 },
                new Stock(3, 1, 1, 0, true) { Id = 3 },

                new Stock(4, 1, 2, 3, true) { Id = 4 },
                new Stock(5, 1, 2, 1, true) { Id = 5 },
                new Stock(6, 1, 1, 4, true) { Id = 6 },

                new Stock(7, 1, 1, 12, true) { Id = 7 },
            };
        }
    }
}
