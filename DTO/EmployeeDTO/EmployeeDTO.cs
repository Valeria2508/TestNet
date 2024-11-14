using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.DTO.EmployeeDTO
{
    public class EmployeeDTO
    {
        public  int Id { get; set; }
        public required string FirstNameName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Position { get; set; }
        public required string IdentificationNumber { get; set; }
        public required string Password { get; set; }
    }
}