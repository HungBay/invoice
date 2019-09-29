using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirstInvoice.Repository;
using EFCodeFirstInvoice.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFCodeFirstInvoice
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
            services.AddDbContext<InvoiceDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("myConnect")));
            services.AddTransient<IProduct, ProductRepository>();
            services.AddTransient<ICustomer, CustomerRepository>();
            services.AddTransient<IInvoice, InvoiceRepository>();
            services.AddTransient<IInvoiceDetail, InvoiceDetailRepository>();
            services.AddTransient<IInvoiceCustomer, InvoiceCustomerRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseMvc(options => options.MapRoute("default", "{controller=product}/{action=index}/{id?}"));
        }
    }
}
