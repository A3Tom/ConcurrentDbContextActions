using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcurrentDbActions.Domain.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        // Virtual Navigation
        public virtual ICollection<PriceAudit> PriceAudits { get; set; }
        public virtual ICollection<StockAudit> StockAudits { get; set; }

    }
}
