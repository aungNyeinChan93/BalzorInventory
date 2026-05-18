using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.Domain.Entities
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
