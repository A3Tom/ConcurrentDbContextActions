using System.Collections.Generic;

namespace ConcurrentDbActions.Domain.Models
{
    public class Stock
    {
        public int StockId { get; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int LocationId { get; set; }
        public double Quantity { get; private set; }

        // Reverse Navigation
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
        public Location Location { get; set; }

        // Virtual Navigation
        public ICollection<StockAudit> StockAudits { get; set; }
    }
}
