using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConcurrentDbActions.Api.Dataseeds
{
    public static class DataSeedInitializer
    {
        public static IHost SeedData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                try
                {
                    Task.Run(async () =>
                    {
                        var dataSeed = new DataInitializer();
                        await dataSeed.InitializeDataAsync(serviceProvider);
                    });
                }
                catch (Exception ex)
                {
                    var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred whilst data seeding");
                }
            }

            return host;
        }
    }
}
