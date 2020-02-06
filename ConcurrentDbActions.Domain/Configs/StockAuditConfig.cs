using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class StockAuditConfig : IEntityTypeConfiguration<StockAudit>
    {
        public void Configure(EntityTypeBuilder<StockAudit> builder)
        {
            builder.HasKey(x => x.StockAuditId);

            builder.HasOne(x => x.Stock)
                .WithMany(x => x.StockAudits)
                .HasForeignKey(x => x.StockId);

            builder.HasOne(x => x.UpdatedByUser)
                .WithMany(x => x.StockAudits)
                .HasForeignKey(x => x.UpdatedByUserId);
        }
    }
}
