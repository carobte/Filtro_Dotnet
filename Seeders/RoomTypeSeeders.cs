using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro_Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro_Dotnet.Seeders
{
    public class RoomTypeSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Single Room", Description = "A cozy basic room with a single bed, ideal for solo travelers." },
                new RoomType { Id = 2, Name = "Double Room", Description = "Offers flexibility with two single beds or a double bed, perfect for couples or friends." },
                new RoomType { Id = 3, Name = "Suite", Description = "Spacious and luxurious, with a king-sized bed and a separate living area, ideal for those seeking comfort and exclusivity." },
                new RoomType { Id = 4, Name = "Family Room", Description = "Designed for families, with additional space and multiple beds for a comfortable stay." }
            );
        }
    }

}