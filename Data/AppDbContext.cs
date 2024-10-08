using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.Models;
using PruebaNET_CarolinaBustamante.Seeders;
using Microsoft.EntityFrameworkCore;

namespace PruebaNET_CarolinaBustamante.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            RoomTypeSeeders.Seed(modelBuilder);
            RoomSeeders.Seed(modelBuilder);
        } 
    }
}