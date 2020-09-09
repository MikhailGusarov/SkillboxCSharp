using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2512.Data;
using Example_2512.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example_2512.Controllers
{
    public class MixController : Controller
    {
        public IActionResult MixView()
        {
            MixModel model = new MixModel()
            {
                DbWorkers = Repository.GetWorkers(),
                Titles = Repository.GetTitles()
            };


            return View(model);
        }
    }
}