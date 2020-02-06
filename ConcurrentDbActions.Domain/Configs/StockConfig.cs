using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
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
        }
    }
}
