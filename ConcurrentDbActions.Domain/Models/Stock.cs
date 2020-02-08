using System.Collections.Generic;

namespace ConcurrentDbActions.Domain.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; private set; }
        public int WarehouseId { get; private set; }
        public int LocationId { get; private set; }
        public double Quantity { get; private set; }
        public bool Active { get; set; }

        // Reverse Navigation
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
        public Location Location { get; set; }

        // Virtual Navigation
        public ICollection<StockAudit> StockAudits { get; set; }

        public Stock(int productId, int warehouseId, int locationId, double quantity, bool active)
        {
            ProductId = productId;
            WarehouseId = warehouseId;
            LocationId = locationId;
            Quantity = quantity;
            Active = active;
        }
    }
}
