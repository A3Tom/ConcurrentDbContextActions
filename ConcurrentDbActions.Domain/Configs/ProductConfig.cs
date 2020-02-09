using ConcurrentDbActions.Domain.Enums;
using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class ProductConfig : BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.HasData(SeedData());
        }

        private static Product[] SeedData()
        {
            return new Product[]
            {
                new Product("Bread", 0.90m, "Baws00tMate1") { Id = 1, ProductType = ProductTypeEnum.YeastyHings },
                new Product("Tortilla", 1.50m, "Baws00tMate2") {Id = 2,  ProductType = ProductTypeEnum.YeastyHings },
                new Product("Rolls", 0.25m, "Baws00tMate3") { Id = 3, ProductType = ProductTypeEnum.YeastyHings },

                new Product("Chicken", 1.10m, "WTSChickens25c") { Id = 4, ProductType = ProductTypeEnum.Meat },
                new Product("Beef", 2.50m, "WTSChickens25c") { Id = 5, ProductType = ProductTypeEnum.Meat },
                new Product("Cheese", 0.85m, "WTSChickens25c") { Id = 6, ProductType = ProductTypeEnum.Meat },

                new Product("Frogs Legs", 2.50m, "MateStop-FrogsAreSound") { Id = 7, ProductType = ProductTypeEnum.Amphibian }
            };
        }
    }
}
