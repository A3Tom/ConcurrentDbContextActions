using System;
using ConcurrentDbActions.Api.Dataseeds.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrentDbActions.Api.Extensions
{
    public static class DbContextExtensions
    {
        public static void Seed(this DbContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                context.AddRange(LocationDataSeed.Data());
                context.AddRange(ProductDataSeed.Data());
                context.AddRange(StockDataSeed.Data());
                context.AddRange(UserDataSeed.Data());
                context.AddRange(WarehouseDataSeed.Data());

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
