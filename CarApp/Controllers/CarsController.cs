using Microsoft.AspNetCore.Mvc;
using CarApp.Core.ServiceInterface;
using CarApp.Core.Domain;
using CarApp.Core.Interfaces;
using CarApp.Models;

namespace CarApp.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarAppServices _carService;

        public CarsController(ICarAppServices carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var cars = _carService.GetAllCars();
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }
    }
}
