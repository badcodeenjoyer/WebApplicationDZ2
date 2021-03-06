using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace WebApplicationDZ2
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware3
    {
        private readonly RequestDelegate _next;

        public Middleware3(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext , IPublish publish)
        {
            publish.Publish();

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Middleware3Extension
    {
        public static IApplicationBuilder UseMiddleware3(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<Middleware3>();
        }
    }
}
