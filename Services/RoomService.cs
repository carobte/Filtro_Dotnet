using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.DTO.Room;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Services
{
    public class RoomService : IRoomRepository
    {
        public Task<bool> CheckExistence(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoomDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoomDTO>> GetAvailable()
        {
            throw new NotImplementedException();
        }

        public Task<RoomDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoomDTO>> GetOccupied()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoomDTO>> GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}