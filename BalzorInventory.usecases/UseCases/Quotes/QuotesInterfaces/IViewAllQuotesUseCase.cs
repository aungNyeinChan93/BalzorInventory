using BalzorInventory.Domain.Entities;

namespace BalzorInventory.usecases.UseCases.Quotes.QuotesInterfaces
{
    public interface IViewAllQuotesUseCase
    {
        Task<List<Quote>> ExecuteAsync();
    }
}