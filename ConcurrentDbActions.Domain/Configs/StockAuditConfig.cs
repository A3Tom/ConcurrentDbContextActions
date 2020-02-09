using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class StockAuditConfig : BaseConfig<StockAudit>
    {
        public override void Configure(EntityTypeBuilder<StockAudit> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Stock)
                .WithMany(x => x.StockAudits)
                .HasForeignKey(x => x.StockId);

            builder.HasOne(x => x.UpdatedByUser)
                .WithMany(x => x.StockAudits)
                .HasForeignKey(x => x.UpdatedByUserId);
        }
    }
}
