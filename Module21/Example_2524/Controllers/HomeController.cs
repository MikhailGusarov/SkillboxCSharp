using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2525.Models;
using Example_2525.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace Example_2525.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.GetWorker());
        }
        public IActionResult Contact()
        {
            return View(Repository.GetWorkers());
        }

        public IActionResult About()
        {
            ViewData["title"] = "ViewData[\"title\"] content";
            ViewData["data"] = "ViewData[\"data\"] content";

            return View();
        }


        public IActionResult Feedback()
        {
            ViewBag.Title = "ViewBag.Title";
            ViewBag.Data = "ViewBag.Data";
            return View();
        }

        public IActionResult NewLayout()
        {
            ViewData["Title"] = "NewLayout";
            return View();
        }

        public IActionResult Integration()
        {
            return View();
        }

    }
}