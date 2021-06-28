using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learningCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace learningCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.

        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        IConfiguration _config;
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
                

            });

            services.AddScoped<IMedicineRepos, MedicineRepos>();

            services.AddDbContextPool<AppDbContext>
                (options => options.UseSqlServer(_config.GetConnectionString("MedicineDB")));
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();



            //  app.UseMvc(routes=> { routes.MapRoute("default", "{controller=Medicine}/{action=Index}/{id?}"); });
            app.UseMvc();

        }

    }
}
