using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Example_2425
{
    public class Startup
    {
        IServiceCollection defaultServices;
        public void ConfigureServices(IServiceCollection services)
        {
            defaultServices = services;
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                var content = new StringBuilder();
                content.Append("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
                content.Append("<table border='2'>");

                content.Append("<tr>");
                content.Append($"<td><font color='gray' size='6'>Наименование сервис</font></td>");
                content.Append($"<td><font color='gray' size='6'>Lifetime</font></td>");
                content.Append("</tr>");

                foreach (var service in defaultServices)
                {
                    content.Append("<tr>");
                    content.Append($"<td><font color='black' size='4'>{service.ServiceType.FullName}</font></td>");
                    content.Append($"<td><font color='black' size='4'>{service.Lifetime}</font></td>");
                    content.Append("</tr>");
                }

                content.Append("</table>");

                await context.Response.WriteAsync(content.ToString());
            });
        }
    }
}
