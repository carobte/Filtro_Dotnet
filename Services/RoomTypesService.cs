using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.Data;
using PruebaNET_CarolinaBustamante.DTO.RoomType;
using PruebaNET_CarolinaBustamante.Models;
using Microsoft.EntityFrameworkCore;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Services
{
    public class RoomTypesService : IRoomTypeRepository
    {
        protected readonly AppDbContext _context;
        public RoomTypesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoomTypeDTO>> Get()
        {
            var roomTypes = await _context.RoomTypes
            .Select(roomType => new RoomTypeDTO
            {
                Id = roomType.Id,
                Name = roomType.Name,
                Description = roomType.Description
            }).ToListAsync();

            return roomTypes;
        }

        public async Task<RoomTypeDTO> GetById(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);

            if (roomType == null)
            {
                return null;
            }

            var roomTypeDTO = new RoomTypeDTO
            {
                Id = roomType.Id,
                Name = roomType.Name,
                Description = roomType.Description
            };

            return roomTypeDTO;
        }
    }


}