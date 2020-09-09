using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example_2511.Data;
using Microsoft.AspNetCore.Mvc;

namespace Example_2511.Controlers
{
    public class WorkersController : Controller
    {
        public string Index()
        {
            var w = Repository.GetWorker();

            string pattern = "Имя: {0} \nВозраст: {1} \nОплата труда: ${2}";

            return String.Format(pattern, w.Name, w.Age, w.Salary);

        }
    }
}