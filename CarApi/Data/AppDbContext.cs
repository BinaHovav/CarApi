using Microsoft.EntityFrameworkCore;
using CarApi.Models;

namespace CarApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Vendor = "Toyota", Power = 150, Price = 20000M },
                new Car { Id = 2, Vendor = "Ford", Power = 180, Price = 25000M },
                new Car { Id = 3, Vendor = "Tesla", Power = 350, Price = 50000M },
                new Car { Id = 4, Vendor = "BMW", Power = 250, Price = 40000M }
            );
        }
    }
}
