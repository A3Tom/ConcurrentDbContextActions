using System.Collections.Generic;
using System.Threading.Tasks;
using ConcurrentDbActions.Domain.Models;
using ConcurrentDbActions.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ConcurrentDbActions.Api.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]
    public class ProductsController : Controller
    {
        private readonly IProductStockroomService _productStockroomService;

        public ProductsController(IProductStockroomService productStockroomService)
        {
            _productStockroomService = productStockroomService;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productStockroomService.GetAllProducts();
        }
    }
}
