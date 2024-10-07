using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_Dotnet.DTO.Room
{
    public class Room
    {
        public int Id { get; set; }
        public required string RoomNumber { get; set; }
        public required double PricePerNight { get; set; }
        public required bool Availability { get; set; }
        public required int MaxOcuppancy { get; set; }
        public required string RoomType { get; set; }
    }
}