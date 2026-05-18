using BalzorInventory.database_01.Data;
using BalzorInventory.Domain.Entities;
using BalzorInventory.usecases.ServiceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.database_01.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly AppDbcontext _context;

        public QuoteService(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<List<Quote>> GetAllQuotesAsync()
        {
            var quotes = await _context.Quotes.AsNoTracking()
                .ToListAsync();

            return quotes;
        }
    }
}
