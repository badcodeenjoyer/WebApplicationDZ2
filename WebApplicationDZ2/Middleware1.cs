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
    public class Middleware1
    {
        private readonly RequestDelegate _next;

        public Middleware1(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext ,IPublish publish)
        {

            publish.Publish();
            await _next(httpContext);
        }
    }
    public static class Middleware1Extensions
    {
        public static IApplicationBuilder UseMiddleware1(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<Middleware1>();
        }
    }
}
