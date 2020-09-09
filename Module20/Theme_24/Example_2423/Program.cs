using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Example_2423
{
    public class Program
    {
        // Конфигурация ASP.NET Core сервера - это объект IConfiguration, хранящий настройки сервера
        // Изменяемый (в процессе работы приложения) словарь "ключ"-"значение"
        // Базовая, JSON, ini, xml

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
