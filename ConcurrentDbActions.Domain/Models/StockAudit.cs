using System;

namespace ConcurrentDbActions.Domain.Models
{
    public class StockAudit
    {
        public int Id { get; }
        public int StockId { get; private set; }
        public double UpdatedQuantity { get; private set; }
        public Guid UpdatedByUserId { get; private set; }

        // Reverse Navigation
        public Stock Stock { get; set; }
        public User UpdatedByUser { get; set; }

        public StockAudit(int stockId, double updatedQuantity, Guid updatedByUserId)
        {
            StockId = stockId;
            UpdatedQuantity = updatedQuantity;
            UpdatedByUserId = updatedByUserId;
        }
    }
}
