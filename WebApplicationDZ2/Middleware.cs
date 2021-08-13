using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Interfaces;

namespace WebApplicationDZ2
{
   
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext , ISave save)
        {
            save.Pub();
            
            
            await _next(httpContext);
        }
       
    }

   
}
