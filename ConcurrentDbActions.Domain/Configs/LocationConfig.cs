using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class LocationConfig : BaseConfig<Location>
    {
        public override void Configure(EntityTypeBuilder<Location> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.HasData(SeedData());
        }

        private static Location[] SeedData()
        {
            return new Location[]
            {
                new Location() { Id = 1, Name = "Dookit Alpha" },
                new Location() { Id = 2, Name = "Warehouse Bravo" },
            };
        }
    }
}
