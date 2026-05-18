using BalzorInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.usecases.ServiceInterfaces
{
    public interface IInventoryService
    {
        Task<List<Inventory>> GetAllInventoriesAsync();
    }
}
