using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using CarViewApp.Data;
using CarViewApp.DataContext;
using Microsoft.Extensions.Logging;

namespace CarViewApp
{
    public class Program
    {

        // Профили
        // Роли
        // Членство

        public static void Main(string[] args)
        {
            var init = BuildWebHost(args);

            using (var scope = init.Services.CreateScope())
            {
                var s = scope.ServiceProvider;
                var c = s.GetRequiredService<CarDbContext>();
                DbInitializer.Initialize(c);
            }

            init.Run();
 
        }

        public static IWebHost BuildWebHost(string[] args) =>

            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(log => log.AddConsole())
                .Build();
    }
}
