using CarApp.Core.Domain;

namespace CarApp.Core.ServiceInterface
{
    public interface ICarAppServices
    {
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
    }
}
