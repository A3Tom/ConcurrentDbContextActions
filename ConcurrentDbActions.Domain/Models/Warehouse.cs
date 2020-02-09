using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ConcurrentDbActions.Domain.Enums;

namespace ConcurrentDbActions.Domain.Models
{
    public class Warehouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public WarehouseTypeEnum WarehouseType { get; set; }

        // Virtual Navigation
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
