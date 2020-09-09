using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
 

namespace Example_2523
{
    public class Program
    {
        //
        // Передача данных из контроллера представлению
        //
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
 

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
