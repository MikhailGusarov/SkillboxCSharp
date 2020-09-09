using System.Collections.Generic;
using CarViewApp.Interfaces;
using CarViewApp.Models;

namespace CarViewApp.Data
{
    public class CarDataTest : ICarData
    {
        static List<Car> data;
        static CarDataTest()
        {
            data = new List<Car>()
            {
                new Car(){Id =1, CarMark="Audi", CarModel="Q9", CarEngine=3 },
                new Car(){Id =2, CarMark="Audi", CarModel="Q7", CarEngine=3 },
                new Car(){Id =3, CarMark="Audi", CarModel="A4", CarEngine=2 }
            }; ;
        }

        public void AddCar(Car car)
        {
            data.Add(car);
        }

        public IEnumerable<Car> GetCars()
        {
            return data;
        }
    }
}
