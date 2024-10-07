using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.DTO.Room;

namespace PruebaNET_CarolinaBustamante.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<RoomDTO>> GetAll();
        Task<RoomDTO> GetById(int id);
        Task<IEnumerable<RoomDTO>> GetAvailable();
        Task<IEnumerable<RoomDTO>> GetOccupied();
    }
}