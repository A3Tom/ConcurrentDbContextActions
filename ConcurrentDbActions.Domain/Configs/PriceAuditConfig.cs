using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class PriceAuditConfig : BaseConfig<PriceAudit>
    {
        public override void Configure(EntityTypeBuilder<PriceAudit> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.PriceAudits)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.UpdatedByUser)
                .WithMany(x => x.PriceAudits)
                .HasForeignKey(x => x.UpdatedByUserId);
        }
    }
}
