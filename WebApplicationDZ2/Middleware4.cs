using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.AspNetCore.Mvc;




namespace WebApplicationDZ2
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware4
    {
        private readonly RequestDelegate _next;

        public Middleware4(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext , ILogic logic , IPublish publish, IContent content, ICheck check, ISave save)
        {
            logic.DoAllLogic(publish,content,check,save);
            Res(httpContext, save,check);
            await _next(httpContext);
        }



        public void Res(HttpContext httpContext, ISave save , ICheck check)
        {
            var lst = new List<string>();
            
            foreach (var item in save.Pub())
            {
                lst.Add(item);
            }
            foreach (var item in lst)
            {
                httpContext.Response.WriteAsync(item);
            }

        }



    }



}
