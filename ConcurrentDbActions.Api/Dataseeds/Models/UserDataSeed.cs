using System;
using System.Collections.Generic;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Api.Dataseeds.Models
{
    public static class UserDataSeed
    {
        public static ICollection<User> Data()
        {
            return new User[]
            {
                new User() { UserId = new Guid(), Email = "Tom.Smith@CosmicSafari.co.uk", Name = "Tom", Username = "Hingsmaster" }
            };
        }
    }
}
