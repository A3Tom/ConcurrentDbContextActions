using System.Collections.Generic;
using ConcurrentDbActions.Domain.Enums;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Api.Dataseeds.Models
{
    public static class WarehouseDataSeed
    {
        public static ICollection<Warehouse> Data()
        {
            return new Warehouse[]
            {
                new Warehouse() {Id = 1 , Name = "Home", WarehouseType = WarehouseTypeEnum.Default}
            };
        }
    }
}
