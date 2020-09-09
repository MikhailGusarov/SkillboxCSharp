using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CarViewApp.AuthCarApp;
using CarViewApp.Models;

namespace CarViewApp.DataContext
{
    public class CarDbContext : IdentityDbContext<User>
    {
        public CarDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
    }
}

 
