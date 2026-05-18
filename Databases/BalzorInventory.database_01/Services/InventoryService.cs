using BalzorInventory.database_01.Data;
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
    }
}
