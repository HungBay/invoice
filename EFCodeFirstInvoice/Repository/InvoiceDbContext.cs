using EFCodeFirstInvoice.Models;
using EFCodeFirstInvoice.Models.viewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Repository
{
    public class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Invoice_detail> Invoice_details { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }
}
