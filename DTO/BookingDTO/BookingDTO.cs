using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.DTO.BookingDTO
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required double TotalCost { get; set; }
        public required int RoomId { get; set; }
        public required int GuestId { get; set; }
        public required int GuestName { get; set; }
        public required int EmployeeId { get; set; }
        public required string EmployeeName { get; set; }
    }
}