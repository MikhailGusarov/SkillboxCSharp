using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2512.Data;
using Microsoft.AspNetCore.Mvc;

namespace Example_2512.Controllers
{
    public class ListWorkersController : Controller
    {
        public IActionResult Index()
        {

            return View(Repository.GetWorkers());
        }
    }
}