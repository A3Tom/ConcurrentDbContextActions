using System;
using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.UserId);

            builder.HasData(SeedData());
        }

        private static User[] SeedData()
        {
            return new User[]
            {
                new User() { UserId = Guid.NewGuid(), Email = "Tom.Smith@CosmicSafari.co.uk", Name = "Tom", Username = "Hingsmaster" }
            };
        }
    }
}
