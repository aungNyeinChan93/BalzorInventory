using BalzorInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.usecases.ServiceInterfaces
{
    public interface IQuoteService
    {
        Task<List<Quote>> GetAllQuotesAsync();


    }
}
