using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.DTO.Guest;

namespace PruebaNET_CarolinaBustamante.Repositories
{
    public interface IGuestRepository
    {
        Task<IEnumerable<GuestDTO>> Get();
        Task<GuestDTO> GetById(int id);
        Task<GuestDTO> GetByKeyword(string keyword);
        Task Register(GuestDTO guestDTO);
        Task Delete(int id);
        Task Update(int id, GuestDTO guestDTO);
    }
}