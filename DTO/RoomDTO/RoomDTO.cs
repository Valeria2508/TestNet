using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.DTO.RoomDTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public required string RoomNumber { get; set; }
        public required decimal PriceNight { get; set; }
        public required bool Aviability { get; set; }
        public required string RoomTypeName { get; set; }
    }
}