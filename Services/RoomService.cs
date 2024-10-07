using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_CarolinaBustamante.Data;
using PruebaNET_CarolinaBustamante.DTO.Room;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Services
{

    public class RoomService : IRoomRepository
    {
        protected readonly AppDbContext _context;

        public RoomService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoomDTO>> GetAll()
        {
            var rooms = await _context.Rooms
            .Include(room => room.RoomType)
            .Select(room => new RoomDTO
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOcuppancy = room.MaxOcuppancy,
                RoomType = room.RoomType.Name
            }).ToListAsync();

            return rooms;
        }

        public async Task<IEnumerable<RoomDTO>> GetAvailable()
        {
            var roomsAvailable = await _context.Rooms
            .Include(room => room.RoomType)
            .Where(room => room.Availability)
            .Select(room => new RoomDTO
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOcuppancy = room.MaxOcuppancy,
                RoomType = room.RoomType.Name
            }).ToListAsync();

            return roomsAvailable;
        }

        public async Task<RoomDTO> GetById(int id)
        {
            var room = await _context.Rooms
            .Include(room => room.RoomType)
            .FirstOrDefaultAsync(room => room.Id == id);

            if (room == null)
            {
                return null;
            }

            var roomDto = new RoomDTO
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOcuppancy = room.MaxOcuppancy,
                RoomType = room.RoomType.Name
            };

            return roomDto;
        }

        public async Task<IEnumerable<RoomDTO>> GetOccupied()
        {

            var roomsOccupied = await _context.Rooms
              .Include(room => room.RoomType)
              .Where(room => !room.Availability)
              .Select(room => new RoomDTO
              {
                  Id = room.Id,
                  RoomNumber = room.RoomNumber,
                  PricePerNight = room.PricePerNight,
                  Availability = room.Availability,
                  MaxOcuppancy = room.MaxOcuppancy,
                  RoomType = room.RoomType.Name
              }).ToListAsync();

            return roomsOccupied;
        }
        
        public async Task<IEnumerable<RoomStatusDTO>> GetByStatus()
        {
            var rooms = await _context.Rooms
            .OrderByDescending(room => room.Availability)
            .Select(room => new RoomStatusDTO
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                Availability = room.Availability,
            }).ToListAsync();
            
            return rooms;
        }
    }
}