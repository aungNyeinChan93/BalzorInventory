using BalzorInventory.database_01.Data;
using BalzorInventory.Domain.Dtos.Inventories;
using BalzorInventory.Domain.Entities;
using BalzorInventory.usecases.ServiceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.database_01.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly AppDbcontext _context;

        public InventoryService(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<List<Inventory>> GetAllInventoriesAsync()
        {
            var inventories = await _context.Inventories.AsNoTracking().ToListAsync();
            return inventories;
        }

        public async Task<bool> CreateInventoryAsync(CreateInventoryDto createInventoryDto)
        {
            var newInventory = new Inventory
            {
                Name = createInventoryDto.Name,
                Price = createInventoryDto.Price,
                Quantity = createInventoryDto.Quantity,
            };

            await _context.Inventories.AddAsync(newInventory);
            var result = await _context.SaveChangesAsync();
            return result >= 1 ? true : false;
        }

        public async Task<List<Inventory>?> GetInventoriesByNameAsync(string inventoryName)
        {
            if (string.IsNullOrEmpty(inventoryName)) return default!;

            var inventories = await _context.Inventories
                .AsNoTracking()
                .Where(x => x.Name.Contains(inventoryName))
                .ToListAsync();

            if (inventories is null || inventories.Count <= 0) return default!;

            return inventories;

        }
    }
}
