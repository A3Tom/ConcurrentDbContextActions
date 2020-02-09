using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcurrentDbActions.Domain.Models
{
    public class Stock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int LocationId { get; set; }
        public double Quantity { get; set; }
        public bool Active { get; set; }

        // Reverse Navigation
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
        public Location Location { get; set; }

        // Virtual Navigation
        public ICollection<StockAudit> StockAudits { get; set; }

        public Stock()
        {

        }

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
