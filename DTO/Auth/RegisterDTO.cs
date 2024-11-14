using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestNet.DTO.Auth
{
    public class RegisterDTO
    {
    
        public required string Name { get; set; }
        public required string LastName { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
        
        [PasswordPropertyText]
        public required string Password { get; set; }
    }
}