using BalzorInventory.Domain.Dtos.Inventories;
using BalzorInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.usecases.ServiceInterfaces
{
    public interface IInventoryService
    {
        Task<List<Inventory>> GetAllInventoriesAsync();
        Task<bool> CreateInventoryAsync(CreateInventoryDto createInventoryDto);

        Task<List<Inventory>?> GetInventoriesByNameAsync(string inventoryName);
    }
}
