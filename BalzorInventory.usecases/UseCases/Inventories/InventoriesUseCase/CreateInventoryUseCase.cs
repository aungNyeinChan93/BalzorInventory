using BalzorInventory.Domain.Dtos.Inventories;
using BalzorInventory.usecases.ServiceInterfaces;
using BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCase
{
    public class CreateInventoryUseCase : ICreateInventoryUseCase
    {

        private readonly IInventoryService _inventoryService;

        public CreateInventoryUseCase(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public async Task<bool> ExecuteAsync(CreateInventoryDto dto)
        {
            var result = await _inventoryService.CreateInventoryAsync(dto);
            return result;
        }
    }
}
