using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_CarolinaBustamante.Data;
using PruebaNET_CarolinaBustamante.DTO.Guest;
using PruebaNET_CarolinaBustamante.Models;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Services
{
    public class GuestService : IGuestRepository
    {
        protected readonly AppDbContext _context;

        public GuestService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<GuestDTO>> Get()
        {
            var guests = await _context.Guests
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

            return guests;
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

        public async Task Register(GuestDTO guestDTO)
        {
            var guest = new Guest
            {
                FirstName = guestDTO.FirstName,
                LastName = guestDTO.LastName,
                Email = guestDTO.Email,
                IdNumber = guestDTO.IdNumber,
                Phone = guestDTO.PhoneNumber,
                BirthDate = guestDTO.BirthDate
            };
            await _context.Guests.AddAsync(guest);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, GuestDTO guestDTO)
        {
        var guest = await _context.Guests.FindAsync(id);
        if (guest != null)
        {
            guest.Id = guest.Id;
            guest.FirstName = guestDTO.FirstName;
            guest.LastName = guestDTO.LastName;
            guest.Email = guestDTO.Email;
            guest.IdNumber = guestDTO.IdNumber;
            guest.Phone = guestDTO.PhoneNumber;
            guest.BirthDate = guestDTO.BirthDate;
            
            await _context.SaveChangesAsync();
        }
        }
    }
}