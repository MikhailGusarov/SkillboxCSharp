using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Example_2431
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSpaStaticFiles();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {

            app.UseStaticFiles();
            app.UseMvc(

                r =>
                {
                    r.MapRoute(
                        name: "default",
                        template: "{controller=MyDefault}/{action=Index}"

                        );
                });

        }
    }
}