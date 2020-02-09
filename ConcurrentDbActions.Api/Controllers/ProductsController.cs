using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcurrentDbActions.Domain.Constants;
using ConcurrentDbActions.Domain.Models;
using ConcurrentDbActions.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ConcurrentDbActions.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route(Routes.DefaultVersionedApiRoute)]
    public class ProductsController : BaseController
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

        //[HttpPost]
        //public async Task<int> AddProducts([FromBody] Product productsToAdd)
        //{
        //    return await _productStockroomService.AddProduct(product);
        //}
    }
}
