using CarApi.Models;
using CarApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cars = _carService.GetCars();
            return Ok(cars);
        }
    }
}
