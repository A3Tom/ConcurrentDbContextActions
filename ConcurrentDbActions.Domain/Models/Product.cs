﻿using System.Collections.Generic;
using ConcurrentDbActions.Domain.Enums;

namespace ConcurrentDbActions.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
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

        public Product(string name, decimal price, string barcode)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
        }
    }
}
