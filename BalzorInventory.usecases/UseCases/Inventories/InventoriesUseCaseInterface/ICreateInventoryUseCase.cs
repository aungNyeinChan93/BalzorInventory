using BalzorInventory.Domain.Dtos.Inventories;

namespace BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCaseInterface
{
    public interface ICreateInventoryUseCase
    {
        Task<bool> ExecuteAsync(CreateInventoryDto dto);
    }
}