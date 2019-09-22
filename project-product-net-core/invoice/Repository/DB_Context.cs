using invoice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models.viewModel;

namespace invoice.Repository
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Invoice_details> Invoice_details { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<invoice.Models.viewModel.InvoiceView> InvoiceView { get; set; }
    }
}
