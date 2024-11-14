using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.Models
{
    [Table("room_types")]
    public class RoomType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public required int Id {get;set;}
        [Column("name")]
        public required string Name {get;set;}
        [Column("description")]
        public required string Description {get;set;}

        public ICollection<Room> Rooms {get;set;} //no entiendo esta linea de codigo
    }
}