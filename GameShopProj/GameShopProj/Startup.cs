using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShopProj
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           /* app.Use(async ( ctx , next) =>
            {
                await ctx.Response.WriteAsync("1.Hello from the other side.\n");

                await next();

                
            });
            app.Use(async ( ctx , next) =>
            {
                await ctx.Response.WriteAsync("2.Hello from my side.\n");

                await ctx.Response.WriteAsync("1.How are you?\n");

                await ctx.Response.WriteAsync("2.Alhamdullialh I am good.\nWhat about you?\n");

                await ctx.Response.WriteAsync("1.I am also good.");

            }); */
           app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });

            /* app.UseEndpoints(endpoints =>
             {
                 endpoints.MapDefaultControllerRoute();
             }); */

            /* app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/zarrar", async context =>
                {
                    await context.Response.WriteAsync("Hello!");
                });
            }); */
        }
    }
}
