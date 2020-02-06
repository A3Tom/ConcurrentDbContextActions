using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class PriceAuditConfig : IEntityTypeConfiguration<PriceAudit>
    {
        public void Configure(EntityTypeBuilder<PriceAudit> builder)
        {
            builder.HasKey(x => x.PriceAuditId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.PriceAudits)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.UpdatedByUser)
                .WithMany(x => x.PriceAudits)
                .HasForeignKey(x => x.UpdatedByUserId);
        }
    }
}
