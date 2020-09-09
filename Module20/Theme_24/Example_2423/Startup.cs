using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Example_2423
{
    public class Startup
    {
        IConfiguration config;

        public Startup()
        {
            // Хранение настроек в памяти
            config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string>()
                                                {
                                                    { "username", "admin" },
                                                    { "password", "qwerty" },
                                                    { "color", "#0000ff" },
                                                    { "font-size", "14px" },
                                                })
                                                .Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {

        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region runtime

            //config["username"] = $"user_{env.ApplicationName}";
            //config["password"] = $"password_{env.EnvironmentName}";

            #endregion

           
            app.Run(async (context) =>
            {
                string content = String.Format(
                    "<p style='color:{0}; font-size:{1};'>[{2} {3}]</p>",
                    config["color"],
                    config["font-size"],
                    $"Username : {config["username"]}",
                    $"Password: {config["password"]}"
                    );

                await context.Response.WriteAsync(content);
            });
        }
    }
}
