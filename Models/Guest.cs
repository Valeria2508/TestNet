using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public required int Id { get; set; }
        [Column("first_name")]
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public required string FirstName { get; set; }
        [Column("last_name")]
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public required string LastName { get; set; }
        [Column("email")]
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; }
        [Column("identification_number")]
        [Required]
        [MaxLength(20)]
        public required string IdentificationNumber { get; set; }
        
        [Column("phone_number")]
        [Required]
        [MaxLength(20)]
        [Phone]
        public required string PhoneNumber { get; set; }

        [Column("birthDate")]
        [Required]
        public required DateTime BirthDate { get; set; }

        public ICollection<Boocking> Boockings {get; set;}

    }
}