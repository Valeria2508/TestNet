using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public required int Id { get; set; }

        [Column("room_number")]
        public required string RoomNumber { get; set; }

        [Column("price_night")]
        public required decimal PriceNight { get; set; }

        [Column("aviability")]
        public required bool Aviability { get; set; }

        //relaciones
        [ForeignKey("room_type_id")]
        public int RoomTypeId { get;set;}
        public RoomType RoomTypes { get; set; } //no entiendo esta linea de codigo
    }
}