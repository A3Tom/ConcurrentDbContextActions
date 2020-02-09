using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcurrentDbActions.Domain.Models
{
    public class PriceAudit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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
