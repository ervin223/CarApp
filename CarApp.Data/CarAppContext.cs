using CarApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarApp.Data
{
    public class CarAppContext : DbContext
    {
        public CarAppContext(DbContextOptions<CarAppContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
    }
}
