using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarApp.Models  
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
