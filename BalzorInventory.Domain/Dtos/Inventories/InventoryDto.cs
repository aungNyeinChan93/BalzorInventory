using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BalzorInventory.Domain.Dtos.Inventories
{
    public class InventoryDto
    {
        public int InventoryId { get; set; }
        public required string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class CreateInventoryDto
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        [Range(0,999999999)]
        public required decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
