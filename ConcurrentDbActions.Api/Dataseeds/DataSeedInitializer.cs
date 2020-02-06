using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConcurrentDbActions.Api.Dataseeds
{
    public static class DataSeedInitializer
    {
        public static IWebHost SeedData(this IWebHost host)
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
