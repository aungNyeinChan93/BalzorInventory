using BalzorInventory.Domain.Entities;

namespace BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCaseInterface
{
    public interface IViewInventoriesUseCase
    {
        Task<List<Inventory>> ViewAllInventories();
    }
}