using System.Collections.Generic;
using System.Threading.Tasks;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Service.Abstract
{
    public interface IProductStockroomService
    {
        Task<List<Product>> GetAllProducts();
    }
}
