using CarApi.Data;
using CarApi.Models;

namespace CarApi.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext _context;

        public CarService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Cars.ToList();
        }
    }
}
