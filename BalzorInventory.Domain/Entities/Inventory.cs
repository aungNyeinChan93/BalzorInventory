using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.Domain.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
