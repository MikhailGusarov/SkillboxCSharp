using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Example_2426
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUpTimeService, UpTimeServiceMinutes>();
            //services.AddTransient<UpTimeServiceSecond>();
        }

        public void Configure(IApplicationBuilder app, IUpTimeService time)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"UpTimeServer: {time.UpTimeSpan}");
            });
        }
    }
}
