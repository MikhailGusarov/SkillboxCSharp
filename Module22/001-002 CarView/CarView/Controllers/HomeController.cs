using System;
using System.Collections.Generic;
using CarViewApp.Models;
using Microsoft.AspNetCore.Mvc;
using CarViewApp.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace CarViewApp.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly ICarData carData;

        public HomeController(ICarData CarData)
        {
            this.carData = CarData;
        }

        public IActionResult Index()
        {
            return View(carData.GetCars());
        }

        [HttpGet]
        //[AllowAnonymous]
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetDataFromViewField(string carModel, string carMark, double carEngine)
        {
            var car = new Car()
            {
                CarModel = carModel,
                CarMark = carMark,
                CarEngine = carEngine
            };

            carData.AddCar(car);
            return Redirect("~/");
        }

    }
}