using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcurrentDbActions.Data.Abstract;
using ConcurrentDbActions.Domain.Contexts;
using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcurrentDbActions.Data.Concrete
{
    public class StockroomRepository : IStockroomRepository
    {
        private readonly StockroomDbContext _dbContext;

        public StockroomRepository()
        {
            _dbContext = new StockroomDbContext();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products
                .ToListAsync();
        }
    }
}
