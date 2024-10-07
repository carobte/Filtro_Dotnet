using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.DTO.RoomType;
using PruebaNET_CarolinaBustamante.Models;

namespace PruebaNET_CarolinaBustamante.Repositories
{
    public interface IRoomTypeRepository
    {
        Task<IEnumerable<RoomTypeDTO>> Get();
        Task<RoomTypeDTO> GetById(int id);
    }
}