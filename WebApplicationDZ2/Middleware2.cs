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
    public class Middleware2
    {
        private readonly RequestDelegate _next;

        public Middleware2(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext , ICheck check)
        {

            check.CheckPublication();
            await _next(httpContext);
        }
        // Extension method used to add the middleware to the HTTP request pipeline.
        
    }

    
   
}
