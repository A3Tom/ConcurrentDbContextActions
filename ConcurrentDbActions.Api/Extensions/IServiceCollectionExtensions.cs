using ConcurrentDbActions.Data.Abstract;
using ConcurrentDbActions.Data.Concrete;
using ConcurrentDbActions.Domain.Contexts;
using ConcurrentDbActions.Service.Abstract;
using ConcurrentDbActions.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ConcurrentDbActions.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterModules(this IServiceCollection services)
        {
            // Data Layer
            services.AddSingleton<IStockroomRepository, StockroomRepository>();

            // Service Layer
            services.AddSingleton<IProductStockroomService, ProductStockroomService>();

            return services;
        }
    }
}
