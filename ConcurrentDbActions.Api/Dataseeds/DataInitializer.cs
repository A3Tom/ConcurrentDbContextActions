using System;
using System.Threading.Tasks;
using ConcurrentDbActions.Api.Dataseeds.Models;
using ConcurrentDbActions.Domain.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace ConcurrentDbActions.Api.Dataseeds
{
    public class DataInitializer
    {
        private StockroomDbContext _context;
        public async Task InitializeDataAsync(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<StockroomDbContext>();

            _context.Database.EnsureCreated();

            _context.AddRange(LocationDataSeed.Data());
            _context.AddRange(ProductDataSeed.Data());
            _context.AddRange(StockDataSeed.Data());
            _context.AddRange(UserDataSeed.Data());
            _context.AddRange(WarehouseDataSeed.Data());

            await _context.SaveChangesAsync();
        }
    }
}
