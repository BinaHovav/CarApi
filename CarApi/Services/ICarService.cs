using CarApi.Models;

namespace CarApi.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
    }
}
