﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDZ2
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public static class MiddlewareExtension2
    {


        public static IApplicationBuilder UseMiddleware4(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware4>();
        }


    }
}
