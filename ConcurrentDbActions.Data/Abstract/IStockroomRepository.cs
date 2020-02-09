using System.Collections.Generic;
using System.Threading.Tasks;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Data.Abstract
{
    public interface IStockroomRepository
    {
        Task<Product> GetProductById(int productId);

        Task<List<Product>> GetAllProducts();
    }
}
