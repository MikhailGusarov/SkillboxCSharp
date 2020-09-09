using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
   
    public static class  Repository  
    {
        static List<ICar> data;
        static Repository()
        {
            data = new List<ICar>()
            {
                new Car(){Id = 0, CarMark="Audi", CarModel="A4", CarEngine=2 },
                new Car(){Id = 1, CarMark="Audi", CarModel="SQ8", CarEngine=4 },
                new Car(){Id = 2, CarMark="Audi", CarModel="Q7", CarEngine=3 },
                new Car(){Id = 3, CarMark="Audi", CarModel="RS7", CarEngine=4 },
                new Car(){Id = 4, CarMark="Audi", CarModel="RS6", CarEngine=4 },
                new Car(){Id = 5, CarMark="Audi", CarModel="S5", CarEngine=3 },
            };
        }

        public static void AddCar(ICar car)
        {
            car.Id = data.Count;    
            data.Add(car);
        }

        public static IEnumerable<ICar> GetCars() => data;

        public static ICar GetCarById(int Id) => Id >= 0 && Id < data.Count ? data[Id] : NullCar.Create();
        public static IEnumerable<ICar> GetCarsRange(int pos, int count)
            => data.Where(car => car.Id >= pos && car.Id < pos + count);
    }
}
