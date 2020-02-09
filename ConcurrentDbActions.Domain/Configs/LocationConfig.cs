using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
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
