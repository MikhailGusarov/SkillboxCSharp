using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Example_2431.Controllers
{
    public class MyDefaultController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }
    }
}