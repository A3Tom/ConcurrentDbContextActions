using System.Collections.Generic;
using System.Threading.Tasks;
using ConcurrentDbActions.Data.Abstract;
using ConcurrentDbActions.Domain.Models;
using ConcurrentDbActions.Service.Abstract;

namespace ConcurrentDbActions.Service.Concrete
{
    public class ProductStockroomService : IProductStockroomService
    {
        private readonly IStockroomRepository _stockroomRepository;

        public ProductStockroomService(IStockroomRepository stockroomRepository)
        {
            _stockroomRepository = stockroomRepository;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _stockroomRepository.GetAllProducts();
        }
    }
}
