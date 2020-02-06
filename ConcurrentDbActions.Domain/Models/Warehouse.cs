using ConcurrentDbActions.Domain.Enums;
using System.Collections.Generic;

namespace ConcurrentDbActions.Domain.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WarehouseTypeEnum WarehouseType { get; set; }

        // Virtual Navigation
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
