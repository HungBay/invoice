using Microsoft.EntityFrameworkCore;
using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Repositories
{
    public class SaleOfPastriesDbContext : DbContext
    {
        public SaleOfPastriesDbContext(DbContextOptions<SaleOfPastriesDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<NewProduct> NewProducts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
    }
}
