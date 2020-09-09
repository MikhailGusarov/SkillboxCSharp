using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examplе_2541.ContextFolder;
using Examplе_2541.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace Examplе_2541.Controllers
{
    public class CarController : Controller
    {

        public IActionResult Index() => View();
        public IActionResult AllView()
        {
            ViewBag.Cars = new DataContext().Cars;
            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetDataFromViewField(string carModel, string carMark, double carEngine)
        {
            using (var db = new DataContext())
            {
                db.Cars.Add(
                    new Car()
                    {
                        CarModel = carModel,
                        CarMark = carMark,
                        CarEngine = carEngine
                    });

                db.SaveChanges();
            }
            return Redirect("~/");
        }
    }        
    
}