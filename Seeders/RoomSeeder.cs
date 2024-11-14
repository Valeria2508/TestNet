using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.Models;

namespace TestNet.Seeders
{
    public class RoomSeeder
    {
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Room>().HasData(
            // Rooms 101-110 with mixed RoomTypeId
            new Room { Id = 1, RoomNumber = "101", PriceNight = 50, Aviability = true, RoomTypeId = 2 },  // Double Room
            new Room { Id = 2, RoomNumber = "102", PriceNight = 150, Aviability = false, RoomTypeId = 4 }, // Family Room
            new Room { Id = 3, RoomNumber = "103", PriceNight = 80, Aviability = true, RoomTypeId = 1 },  // Single Room
            new Room { Id = 4, RoomNumber = "104", PriceNight = 200, Aviability = true, RoomTypeId = 3 }, // Suite
            new Room { Id = 5, RoomNumber = "105", PriceNight = 50, Aviability = false, RoomTypeId = 2 },  // Double Room
            new Room { Id = 6, RoomNumber = "106", PriceNight = 150, Aviability = true, RoomTypeId = 3 }, // Suite
            new Room { Id = 7, RoomNumber = "107", PriceNight = 80, Aviability = false, RoomTypeId = 4 },  // Family Room
            new Room { Id = 8, RoomNumber = "108", PriceNight = 200, Aviability = true, RoomTypeId = 1 }, // Single Room
            new Room { Id = 9, RoomNumber = "109", PriceNight = 50, Aviability = true, RoomTypeId = 3 },  // Suite
            new Room { Id = 10, RoomNumber = "110", PriceNight = 150, Aviability = false, RoomTypeId = 2 } // Double Room
            );
        }
    }
}