using System;
using ConcurrentDbActions.Api.Dataseeds.Models;
using ConcurrentDbActions.Domain.Contexts;

namespace ConcurrentDbActions.Api.Extensions
{
    public static class IServiceProviderExtensions
    {
        public static IServiceProvider UseSeedData(this IServiceProvider serviceProvider)
        {
            var _context = (StockroomDbContext)serviceProvider.GetService(typeof(StockroomDbContext));

            _context.Database.EnsureCreated();

            _context.AddRange(LocationDataSeed.Data());
            _context.AddRange(ProductDataSeed.Data());
            _context.AddRange(StockDataSeed.Data());
            _context.AddRange(UserDataSeed.Data());
            _context.AddRange(WarehouseDataSeed.Data());

            _context.SaveChanges();

            return serviceProvider;
        }
    }
}
