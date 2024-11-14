using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public required int Id { get; set; }
        [Column("first_name")]
        [Required]
        [MaxLength(50)]
        public required string FirstNameName { get; set; }
        [Column("last_name")]
        [Required]
        [MaxLength(50)]
        public required string LastName { get; set; }
        [Column("email")]
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; }

        [Column("position")]
        [Required]
        [MaxLength(50)]
        public required string Position { get; set; }
        [Column("identification_number")]
        [Required]
        [MaxLength(20)]
        public required string IdentificationNumber { get; set; }
        [Column("password")]
        [Required]
        [MaxLength(255)]
        public required string Password {get; set;}


        public ICollection<Boocking> Boockings {get; set;}
        

    }
}