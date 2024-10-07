using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro_Dotnet.DTO.RoomType;
using Filtro_Dotnet.Models;

namespace PruebaNET_CarolinaBustamante.Repositories
{
    public interface IRoomTypeRepository
    {
        Task<IEnumerable<RoomTypeDTO>> Get();
        Task<RoomTypeDTO> GetById(int id);
    }
}