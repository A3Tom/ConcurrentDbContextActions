using System.Collections.Generic;
using ConcurrentDbActions.Domain.Enums;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Api.Dataseeds.Models
{
    public static class ProductDataSeed
    {
        public static ICollection<Product> Data()
        {
            return new Product[]
            {
                new Product("Bread", 0.90m, "Baws00tMate1") { ProductType = ProductTypeEnum.YeastyHings },
                new Product("Tortilla", 1.50m, "Baws00tMate2") { ProductType = ProductTypeEnum.YeastyHings },
                new Product("Rolls", 0.25m, "Baws00tMate3") { ProductType = ProductTypeEnum.YeastyHings },

                new Product("Chicken", 1.10m, "WTSChickens25c") { ProductType = ProductTypeEnum.Meat },
                new Product("Beef", 2.50m, "WTSChickens25c") { ProductType = ProductTypeEnum.Meat },
                new Product("Cheese", 0.85m, "WTSChickens25c") { ProductType = ProductTypeEnum.Meat },

                new Product("Frogs Legs", 2.50m, "MateStop-FrogsAreSound") { ProductType = ProductTypeEnum.Amphibian }
            };
        }
    }
}
