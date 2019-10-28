using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SaleOfPastries.Repositories;
using SaleOfPastries.Services;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Areas.Admin.Reponsitory;

namespace SaleOfPastries
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } 
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
            services.AddDbContext<SaleOfPastriesDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("connect")));
            services.AddTransient<IUser, UserRepository>();
            services.AddTransient<ICustomer, CustomerRepository>();
            services.AddTransient<INewProduct, NewProductRepository>();
            services.AddTransient<ITypeProduct, TypeProductRepository>();
            services.AddTransient<IBill, BillRepository>();
            services.AddTransient<IBillDetail, BillDetailRepository>();
            services.AddTransient<SaleOfPastries.Areas.Admin.Serivice.IProduct, SaleOfPastries.Areas.Admin.Reponsitory.ProductRepository>();
            //view user service
            services.AddTransient<SaleOfPastries.Services.IProduct, SaleOfPastries.Repositories.ProductRepository>();

            services.AddTransient<IUser, UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            app.UseSession();
            app.UseFileServer();
            app.UseMvc(routes =>
            {
                routes.MapAreaRoute(
                  name: "MyAreaAdmin",
                  areaName: "Admin",
                  template: "Admin/{controller=Account}/{action=Index}/{id?}");
                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
            });
            
            //app.UseMvc(options => options.MapRoute("default", "{controller=Home}/{action=Index}/{id?}"));
        }
    }
}
