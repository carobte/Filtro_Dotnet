using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.DTO.Booking;

namespace PruebaNET_CarolinaBustamante.Repositories
{
    public interface IBookingRepository
    {
        Task Create(BookingDTO booking);
        
    }
}