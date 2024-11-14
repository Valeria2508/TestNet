using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.DTO.RoomTypeDTO
{
    public class RoomTypeDTO
    {
        public int Id { get; set;}
        public required string Name { get; set;}
        public required string Description { get; set;}
    }
}