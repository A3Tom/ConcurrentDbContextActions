﻿using ConcurrentDbActions.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcurrentDbActions.Domain.Configs
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder
                .HasKey(x => x.LocationId);
        }
    }
}