using System.Collections.Generic;

namespace ConcurrentDbActions.Domain.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }

        // Virtual Navigation
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
