using System;
using ConcurrentDbActions.Domain.Enums;
using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(SeedData());
        }

        private static Warehouse[] SeedData()   
        {
            return new Warehouse[]
            {
                new Warehouse() { Id = 1 , Name = "Home", WarehouseType = WarehouseTypeEnum.Default}
            };
        }
    }
}
