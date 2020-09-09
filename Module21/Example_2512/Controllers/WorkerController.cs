using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2512.Data;
using Example_2512.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example_2512.Controlers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            Worker w = Repository.GetWorker();

            return View(w);

        }
    }
}