using Microsoft.EntityFrameworkCore;
using Test.ServerManagement.Data;
using Test.ServerManagement.Models;
using Test.ServerManagement.ReqResModels;

namespace Test.ServerManagement.Services
{
    public class CityService
    {
        private readonly AppDbContext _context;

        public CityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BaseResponsModel<List<City>>> GetAllAsync()
        {
            var cities = await _context.Cities.AsNoTracking()
                .ToListAsync();

            return new BaseResponsModel<List<City>>()
            {
                ResponseCode = 200,
                ResponseStatus = true,
                ResponseMessage ="OK",
                Data = cities   
            };
        }
    }
}
