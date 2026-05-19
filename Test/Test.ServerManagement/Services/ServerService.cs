using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Validation;
using Test.ServerManagement.Data;
using Test.ServerManagement.Dtos.Servers;
using Test.ServerManagement.Models;
using Test.ServerManagement.ReqResModels;

namespace Test.ServerManagement.Services
{
    public class ServerService
    {
        private readonly AppDbContext _context;

        public ServerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BaseResponsModel<List<ServerDto>>> GetALLAsync()
        {
            var responseModel = new BaseResponsModel<List<ServerDto>> { };
            var servers = await _context.Servers.AsNoTracking()
                .Include(s=>s.City)
                .Select(s => new ServerDto
                {
                    ServerId = s.ServerId,
                    City = s.City!.Name,
                    IsOnline = s.IsOnline,
                    Name = s.Name
                })
                .ToListAsync();

            if (servers is null || servers.Count < 0)
            {
                responseModel.ResponseStatus = false;
                responseModel.ResponseMessage = "fail";
                responseModel.ResponseCode = 400;
                responseModel.Data = null;
            }

            responseModel = new BaseResponsModel<List<ServerDto>>
            {
                ResponseCode = 200,
                ResponseMessage = "success",
                ResponseStatus = true,
                Data = servers
            };
            return responseModel;
        }

        public async Task<BaseResponsModel<ServerDto>> GetByIdAsync(int id)
        {
            var server = await _context.Servers.AsNoTracking()
                .Include(s=>s.City)
                .Where(s=>s.ServerId == id)
                .Select(s=> new ServerDto
                {
                    Name = s.Name,
                    City = s.City!.Name,
                    IsOnline = s.IsOnline,
                    ServerId = id,
                })
                .FirstOrDefaultAsync();

            return new BaseResponsModel<ServerDto>
            {
                ResponseCode = 200,
                ResponseStatus = true,
                ResponseMessage = "success",
                Data= server
            };
        }

        public async Task<bool> UpdateAsync(ServerDto serverDto)
        {
            if (serverDto is null) return false;

            var updateServer = await _context.Servers.AsNoTracking()
                .FirstOrDefaultAsync(s=>s.ServerId == serverDto.ServerId);

            if (updateServer is null) return false;
           
            var cityId = await _context.Cities.AsNoTracking()
                .Where(x => x.Name == serverDto.City)
                .Select(x => x.CityId)
                .FirstOrDefaultAsync();

            updateServer.CityId = cityId;
            updateServer.Name = serverDto.Name;
            updateServer.IsOnline = serverDto.IsOnline;

            _context.Entry(updateServer).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result >= 1 ? true : false;
        }
    }
}
