using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarViewApp.DataContext;
using CarViewApp.Interfaces;
using CarViewApp.Models;

namespace CarViewApp.Data
{

    public class CarData : ICarData
    {
        private readonly CarDbContext context;

        public CarData(CarDbContext Context)
        {
            this.context = Context;
        }

        public void AddCar(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public IEnumerable<Car> GetCars()
        {
            return this.context.Cars;
        }
    }
}
