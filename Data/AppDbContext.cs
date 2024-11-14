using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.Models;
using TestNet.Seeders;


namespace TestNet.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<RoomType> RoomTypes { get; set; }
         public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Boocking> Bookings { get; set; } 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){ //manda a la db los seeders
            base.OnModelCreating(modelBuilder);
            EmployeeSeeder.Seed(modelBuilder);
            RoomTypeSeeder.Seed(modelBuilder);
            RoomSeeder.Seed(modelBuilder);
        }

    }
}