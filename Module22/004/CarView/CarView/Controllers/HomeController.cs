using System;
using System.Collections.Generic;
using CarViewApp.Models;
using Microsoft.AspNetCore.Mvc;
using CarViewApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace CarViewApp.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly ICarData carData;
        private readonly ILogger log;

        public HomeController(ICarData CarData, ILogger<HomeController> Log)
        {
            this.log = Log;
            this.carData = CarData;
        }

        public IActionResult Index()
        {
            log.LogCritical("Всё хорошо  :-)");
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

            log.LogCritical($" ------- \n >> GetDataFromViewField сработал, carModel = {carModel}\n ------- \n ");


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