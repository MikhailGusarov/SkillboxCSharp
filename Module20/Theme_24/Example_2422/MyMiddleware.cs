using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;

namespace Example_2422
{
    public class MyMiddleware
    {
        RequestDelegate next;

        public MyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext content)
        {
            string type = content.Request.Method;

            if (type == "GET")
            {
                content.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                content.Response.ContentType = "text/plain";
                
                await content.Response.WriteAsync("This service does not support GET request");
            }
            else
            {
                await next.Invoke(content);
            }
        }

    }
}
