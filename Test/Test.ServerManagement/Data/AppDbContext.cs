using Microsoft.EntityFrameworkCore;
using Test.ServerManagement.Models;

namespace Test.ServerManagement.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Server> Servers { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
