using System;
using System.Collections.Generic;
 
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Example_2421
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {


            //app.UseExceptionHandler();



            #region app.Use*

            //app.UseAuthentication(); // - поддержка аутентификации
            //app.UseStaticFiles();
            //app.UseCors(); // - поддержка кроссдоменных запросов
            //app.UseResponseCaching(); // - кэширование результатов запросов
            //app.UseResponseCompression(); // - обеспечивает сжатие ответа клиенту
            //app.UseRouter(); // - определение\переопределение маршрутов, используемых в приложении
            //app.UseSession(); // - поддержка сессий
            //app.UseStaticFiles(); // - поддержка обработки статических файлов

            // Собственные компоненты middleware

            #endregion

            // Замечание - порядок компонентов важен
            // Компоненты middleware создаются единожды

            var timeStart = DateTime.Now;

            app.Run(async (context) =>
            {
                

                await context.Response.WriteAsync($"uptime: {(DateTime.Now - timeStart).TotalSeconds}");
            });
        }



    }
}
