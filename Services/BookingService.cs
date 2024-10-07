using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.Data;
using PruebaNET_CarolinaBustamante.DTO.Booking;
using PruebaNET_CarolinaBustamante.Models;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Services
{
    public class BookingService : IBookingRepository
    {
        protected readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(BookingDTO booking)
        {
            var newBooking = new Booking
            {
                StartDate = booking.StartDate,
                EndDate = booking.EndDate,
                RoomId = booking.RoomId,
                EmployeeId = booking.EmployeeId,
                GuestId = booking.GuestId,
                TotalCost = booking.TotalCost
            };
            
            await _context.Bookings.AddAsync(newBooking);
            await _context.SaveChangesAsync();
        }
    }
}