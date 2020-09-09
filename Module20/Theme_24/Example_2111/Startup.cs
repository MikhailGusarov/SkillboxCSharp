using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Example_2111
{
    /// <summary>
    /// Отвечает за обработку входящих HTTP запросов
    /// </summary>
    public class Startup
    {
        // Подключаем дополнительные сервисы
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthorization(); // cлужбы авторизации
            //services.AddResponseCaching(); // службы кэширования ответов
            //services.AddMvc(); // Добавляет сервисы MVC
        }

        /// <summary>
        /// Конвейер обработки входящих запросов
        /// и генерация ответов на них
        /// </summary>
        /// <param name = "app" > Объект, предоставляющий механизмы для настройки конвейера запросов приложения</param>
        /// <param name = "env" > Объект, предоставляющий информацию о среде веб-хостинга, в которой работает приложение</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        #region -

        ///// <summary>
        ///// Конвейер обработки входящих запросов
        ///// и генерация ответов на них
        ///// </summary>
        ///// <param name="app">Объект, предоставляющий механизмы для настройки конвейера запросов приложения</param>
        ///// <param name="env">Объект, предоставляющий информацию о среде веб-хостинга, в которой работает приложение</param>
        //public void Configure(IApplicationBuilder app)
        //{
        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Hello World!");
        //    });
        //}


        //        /// <summary>
        //        /// Конвейер обработки входящих запросов
        //        /// и генерация ответов на них
        //        /// </summary>
        //        /// <param name="app">Объект, предоставляющий механизмы для настройки конвейера запросов приложения</param>
        //        /// <param name="env">Объект, предоставляющий функционал работы с логами</param>
        //        public void Configure(IApplicationBuilder app, ILoggerFactory logger)
        //        {
        //            logger.AddDebug(); // регистрировать информацию об изменениях на сервере

        //            app.Run(async (context) =>
        //            {
        //                var log = logger.CreateLogger("MyLogger");
        //                log.LogInformation($@">>> LogInformation: 
        //    Headers: {GetHeaders(context.Request.Headers)} 
        //    Path: {context.Request.Path} 
        //    Host: {context.Request.Host}
        //    Protocol: {context.Request.Protocol}
        //{new String('-', 30)}");
        //                await context.Response.WriteAsync("Hello World!");
        //            });
        //        }

        //        private string GetHeaders(IHeaderDictionary pairs)
        //        {
        //            string infoHeaders = String.Empty;
        //            foreach (var item in pairs) infoHeaders += $"\n        {item}";
        //            return infoHeaders;
        //        }




        #endregion



    }
}
