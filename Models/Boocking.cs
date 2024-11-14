using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.Models
{
    [Table("boockings")]
    public class Boocking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public required int Id { get; set; }

        [Required]
        [Column("start_date")]
        public required DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("total_cost")]
        public required double TotalCost { get; set; }

        //foraneas
        [ForeignKey("room_id")]
        public required int RoomId { get; set; }
        public Room Rooms { get; set; }

        [ForeignKey("guest_id")]
        public required int GuestId { get; set; }
        public Guest Guests { get; set; }

        [ForeignKey("employee_id")]
        public required int EmployeeId { get; set; }
        public Employee Employees { get; set; }

    }
}