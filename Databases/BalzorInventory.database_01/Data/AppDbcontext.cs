using BalzorInventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalzorInventory.database_01.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
        {
            
        }

        public DbSet<Quote> Quotes { get; set; }
    }
}
