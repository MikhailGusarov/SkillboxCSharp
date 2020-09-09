using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarViewApp.Models;

namespace CarViewApp.Interfaces
{
    public interface ICarData
    {
        IEnumerable<Car> GetCars();
        void AddCar(Car car);

    }
}
