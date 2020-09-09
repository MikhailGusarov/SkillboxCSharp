using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2512.Data;
using Example_2512.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example_2512.Controllers
{
    public class CollController : Controller
    {
        public IActionResult Data()
        {
            CollWorkers data = new CollWorkers() { CollectionWorkers = Repository.GetWorkers() };
            return View(data);
        }
    }
}