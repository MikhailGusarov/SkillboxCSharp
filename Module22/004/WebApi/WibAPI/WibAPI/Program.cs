using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebAPI
{

    // Сервис-ориентированная архитектура(SOA, англ.service-oriented architecture) 
    // модульный подход к разработке программного обеспечения, 
    // основанный на использовании распределённых, 
    // слабо связанных(англ.loose coupling) заменяемых компонентов, 
    // оснащённых стандартизированными интерфейсами для взаимодействия 
    // по стандартизированным протоколам

    // https://habr.com/ru/company/mailru/blog/342526/
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
