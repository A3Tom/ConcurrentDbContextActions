using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ConcurrentDbActions.Domain.Enums;

namespace ConcurrentDbActions.Domain.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public ProductTypeEnum ProductType { get; set; }
        public decimal Price { get; set; }

        // Virtual Navigation
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<PriceAudit> PriceAudits { get; set; }

        public void RenameProduct(string name) => Name = name;
        public void SetProductPrice(decimal price) => Price = price;
        public void SetBarcode(string barcode) => Barcode = barcode;

        public Product()
        {

        }

        public Product(string name, decimal price, string barcode)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
        }
    }
}
