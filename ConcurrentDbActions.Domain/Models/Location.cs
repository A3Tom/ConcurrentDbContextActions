using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcurrentDbActions.Domain.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        // Virtual Navigation
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
