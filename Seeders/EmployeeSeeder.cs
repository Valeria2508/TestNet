using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.Models;

namespace TestNet.Seeders
{
    public class EmployeeSeeder
    {
        public static void Seed(ModelBuilder modelbuilder){
            modelbuilder.Entity<Employee>().HasData(
                 new Employee 
                { 
                    Id = 1, 
                    FirstNameName = "John", 
                    LastName = "Doe", 
                    Email = "johndoe@example.com", 
                    Position="head of service",
                    IdentificationNumber = "12345678A", 
                    Password = "123456" // Sustituye por una contraseña encriptada si es necesario
                },
                new Employee 
                { 
                    Id = 2, 
                    FirstNameName = "Jane", 
                    LastName = "Smith", 
                    Email = "janesmith@example.com", 
                    Position="recepcionista",
                    IdentificationNumber = "87654321B", 
                    Password = "1245"
                },
                new Employee 
                { 
                    Id = 3, 
                    FirstNameName = "Alice", 
                    LastName = "Johnson", 
                    Email = "alicejohnson@example.com", 
                    Position="manager",
                    IdentificationNumber = "11223344C", 
                    Password = "1346"
                }
            );
        }
    }
}