using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Example_2531.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Example_2531.Controllers
{
    //[NonController]
    public class ContextController : Controller
    {

        // Стандартные обработчики

        //[Route("NotIndex")] 
        //[NonAction]
        public IActionResult Index() => View();
        public int ViewInt() => 2030;
        public (string, int) ViewCortege(int Arg = 10) => ("Курс", Arg);
        public Car ViewCar() => new Car() { CarMark = "Audi", CarModel = "Q8", CarEngine = 3 };
        public IActionResult ContentView() => View("Views/Context/ContentView.cshtml");
        public string RequestMethod() => Request.Method;
        
        // Типы запросов

        [HttpPost]
        public HttpResponseMessage PostResult() => new HttpResponseMessage(HttpStatusCode.BadRequest);


        ////Отправка файлов




        private IHostingEnvironment appEnvironment;

        public ContextController(IHostingEnvironment AppHostingEnvironment)
        {
            appEnvironment = AppHostingEnvironment;
             
        }
        public FileResult GetVirtualFile() => File(@"~\Files\file.pdf", "Application/pdf", "Book___.pdf");
       
        public FileResult GetPhysicalFile()
        {
            return PhysicalFile(
                physicalPath: $@"{appEnvironment.ContentRootPath}\ContentFolder\file.pdf",
                contentType: "Application/pdf",
                fileDownloadName: $"bookfile___.pdf"
                );
        }

        public FileResult GetFileStream()
        {
            return File(
                fileStream: new FileStream($@"{appEnvironment.ContentRootPath}\ContentFolder\file.pdf", FileMode.Open),
                contentType: "Application/pdf",
                fileDownloadName: $"bookfilestream___.pdf"
                );
        }





    }
}