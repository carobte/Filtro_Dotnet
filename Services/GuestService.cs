using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_CarolinaBustamante.Data;
using PruebaNET_CarolinaBustamante.DTO.Guest;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Services
{
    public class GuestService : IGuestRepository
    {
        protected readonly AppDbContext _context;
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GuestDTO>> Get()
        {
            return await _context.Guests
            .Select(guest => new GuestDTO
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdNumber = guest.IdNumber,
                PhoneNumber = guest.Phone,
                BirthDate = guest.BirthDate
            })
            .ToListAsync();
        }

        public async Task<GuestDTO> GetById(int id)
        {
            var guest = await _context.Guests.FindAsync(id);

            if (guest == null)
            {
                return null;
            }

            var guestDto = new GuestDTO
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdNumber = guest.IdNumber,
                PhoneNumber = guest.Phone,
                BirthDate = guest.BirthDate
            };

            return guestDto;
        }

        public async Task<GuestDTO> GetByKeyword(string keyword)
        {
            // Keyword = name or lastname
            var guest = await _context.Guests
            .Where(guest => guest.FirstName.Contains(keyword) || guest.LastName.Contains(keyword))
            .Select(guest => new GuestDTO
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdNumber = guest.IdNumber,
                PhoneNumber = guest.Phone,
                BirthDate = guest.BirthDate
            })

            .FirstOrDefaultAsync();
            
            if (guest == null)
            {
                return null;
            }
            
            return guest;
        }

        public async Task<GuestDTO> Register(GuestDTO guestDTO)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, GuestDTO guestDTO)
        {
            throw new NotImplementedException();
        }
    }
}