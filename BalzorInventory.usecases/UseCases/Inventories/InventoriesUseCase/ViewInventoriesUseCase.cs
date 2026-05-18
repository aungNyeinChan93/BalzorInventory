using BalzorInventory.Domain.Entities;
using BalzorInventory.usecases.ServiceInterfaces;
using BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCase
{
    public class ViewInventoriesUseCase : IViewInventoriesUseCase
    {

        private readonly IInventoryService _inventoryService;

        public ViewInventoriesUseCase(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public async Task<List<Inventory>> ViewAllInventories()
        {
            var inventories = await _inventoryService.GetAllInventoriesAsync();
            return inventories;
        }
    }
}
