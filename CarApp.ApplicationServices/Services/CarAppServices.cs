using CarApp.Core.Domain;
using CarApp.Core.Interfaces;
using CarApp.Core.ServiceInterface;
using CarApp.Data;

namespace CarApp.ApplicationServices.Services
{
    public class CarAppServices : ICarAppServices
    {
        private readonly CarAppContext _context;

        public CarAppServices(CarAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
    }
}
