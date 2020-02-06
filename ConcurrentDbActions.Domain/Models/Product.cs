using ConcurrentDbActions.Domain.Enums;
using System.Collections.Generic;

namespace ConcurrentDbActions.Domain.Models
{
    public class Product
    {
        public int ProductId { get; }
        public string Name { get; private set; }
        public string Barcode { get; private set; }
        public ProductTypeEnum ProductType { get; set; }
        public decimal Price { get; private set; }

        // Virtual Navigation
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<PriceAudit> PriceAudits { get; set; }

        public void RenameProduct(string name) => Name = name;
        public void SetProductPrice(decimal price) => Price = price;
        public void SetBarcode(string barcode) => Barcode = barcode;
    }
}
