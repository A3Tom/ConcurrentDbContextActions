using System.Collections.Generic;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Api.Dataseeds.Models
{
    public static class LocationDataSeed 
    {
        public static ICollection<Location> Data()
        {
            return new Location[]
            {
                new Location() { Id = 1, Name = "Dookit Alpha" },
                new Location() { Id = 2, Name = "Warehouse Bravo" },
            };
        }
    }
}
