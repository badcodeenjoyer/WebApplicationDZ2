using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Interfaces;


namespace WebApplicationDZ2
{
    public class Startup
    {


        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICheck, CheckService>();
            services.AddTransient<IContent, ContentService>();
            services.AddTransient<ILogic, LogicService>();
            services.AddTransient<IPublish, PublishService>();
            services.AddScoped<ISave, SaveInfService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            app.UseMiddleware();
            app.UseMiddleware1();
            app.UseMiddleware2();
            app.UseMiddleware3();
            app.UseMiddleware4();



            app.Run(async (context) =>
            {
                
            app.Map("/publish", async (appBuilder) =>
            {
                
                    app.Use(async (context, next) =>
                    {
                        Console.WriteLine("1");
                        await next();
                        Console.WriteLine("1");
                        await next();
                        Console.WriteLine("1");

                        await next();
                        Console.WriteLine("1");
                        await next();
                        Console.WriteLine("1");
                        await next();


                    });
    
                 });

            }); 

        }
       
    }
}
