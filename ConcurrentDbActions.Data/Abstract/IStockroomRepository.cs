using System.Collections.Generic;
using System.Threading.Tasks;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Data.Abstract
{
    public interface IStockroomRepository
    {
        Task<List<Product>> GetAllProducts();
    }
}
