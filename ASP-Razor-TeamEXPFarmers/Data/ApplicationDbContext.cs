using ASP_Razor_TeamEXPFarmers.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_Razor_TeamEXPFarmers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Person> Customers { get; set; }
        public DbSet<Staff> Staff { get; set; }

        // public DbSet<Order> Orders { get; set;};
        // public DbSet<OrderItem> OrderItems { get; set;};
        public DbSet<Platform> Platforms { get; set;}

        // public DbSet<VideoGame> VideoGames { get; set;};
    }
}
