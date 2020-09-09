 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Example_2424
{
    public class Startup
    {

        IConfiguration config;

        public Startup(IHostingEnvironment env)
        {
            config = new ConfigurationBuilder()
                                .SetBasePath(env.ContentRootPath)
                                .AddJsonFile("SettingsApp.json")
                                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                string content = String.Format(
                    "<p style='color:{0}; font-size:{1};'>[{2} {3}]</p>",
                    config.GetSection("FontStyle").GetSection("color").Value,
                    config.GetSection("FontStyle").GetSection("font-size").Value,

                    $"Username : {config.GetSection("Agent").GetSection("username").Value}",
                    $"Password: {config.GetSection("Agent").GetSection("password").Value}"
                    );
                await context.Response.WriteAsync(content);
            });
        }
    }
}
