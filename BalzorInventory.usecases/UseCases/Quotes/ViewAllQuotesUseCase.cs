using BalzorInventory.Domain.Entities;
using BalzorInventory.usecases.ServiceInterfaces;
using BalzorInventory.usecases.UseCases.Quotes.QuotesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.usecases.UseCases.Quotes
{
    public class ViewAllQuotesUseCase : IViewAllQuotesUseCase
    {
        private readonly IQuoteService _quoteService;

        public ViewAllQuotesUseCase(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public async Task<List<Quote>> ExecuteAsync()
        {
            var quotes = await _quoteService.GetAllQuotesAsync();
            return quotes;
        }
    }
}
