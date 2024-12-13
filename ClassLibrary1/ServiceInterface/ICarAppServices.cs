﻿using CarApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarApp.Core.Interfaces
{
    public interface ICarAppServices
    {
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(int id);
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int id);
    }
}
