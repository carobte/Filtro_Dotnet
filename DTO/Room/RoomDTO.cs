using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_CarolinaBustamante.DTO.Room
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public required string RoomNumber { get; set; }
        public required double PricePerNight { get; set; }
        public required bool Availability { get; set; }
        public required int MaxOcuppancy { get; set; }
        public required string RoomType { get; set; }
    }
}