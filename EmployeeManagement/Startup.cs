using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        private readonly IConfiguration _iConfig;
        public Startup(IConfiguration iConfig)
        {
            _iConfig = iConfig;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //...we enable xml format for api
            services.AddMvc(MvcOptions => MvcOptions.EnableEndpointRouting = false).
                AddXmlSerializerFormatters();

            services.AddDbContext<AppDbContext>(option => 
            option.UseSqlServer(_iConfig.GetConnectionString("Con1"))
            );

            //....depandancy injection (container)
            services.AddScoped<ICompanyRepository<Employee>, SqlEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions option = new DeveloperExceptionPageOptions()
                {
                    SourceCodeLineCount = 0
                };
                app.UseDeveloperExceptionPage(option);
            }

            app.UseFileServer();

            //app.UseMvc();

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default",
                    template: "{controller=Employee}/{action=Index}/{id?}");
            });
        }
    }
}
