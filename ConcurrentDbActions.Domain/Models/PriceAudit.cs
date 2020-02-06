using System;

namespace ConcurrentDbActions.Domain.Models
{
    public class PriceAudit
    {
        public int PriceAuditId { get; }
        public int ProductId { get; private set; }
        public decimal UpdatedPrice { get; private set; }
        public DateTimeOffset ModificationDate { get; private set; }
        public Guid UpdatedByUserId { get; private set; }

        // Reverse Navigation
        public Product Product { get; set; }
        public User UpdatedByUser { get; set; }

        public PriceAudit(int productId, decimal updatedPrice, Guid updatedByUserId)
        {
            ProductId = productId;
            UpdatedPrice = updatedPrice;
            UpdatedByUserId = updatedByUserId;

            ModificationDate = DateTimeOffset.Now;
        }
    }
}
