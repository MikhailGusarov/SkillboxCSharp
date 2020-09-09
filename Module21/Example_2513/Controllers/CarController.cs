using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2513.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example_2513.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetDataFromViewField
            (string carModel, string carMark, double carEngine)
        {
            return $"CarEngine: {carEngine} CarMark: {carMark} CarModel: {carModel}";
        }

        public Car GetDataFromViewObject(Car car)
        {
             return new Car() { CarEngine = car.CarEngine, CarMark = car.CarMark, CarModel = car.CarModel };
        }

        public IEnumerable<Car> GetDataFromViewArrayObject(Car[] cars)
        {
            return cars;
        }
    }
}