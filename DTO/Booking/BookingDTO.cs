using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_CarolinaBustamante.DTO.Booking
{
    public class BookingDTO
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public int EmployeeId { get; set; }
        public double TotalCost { get; set; }
    }
}