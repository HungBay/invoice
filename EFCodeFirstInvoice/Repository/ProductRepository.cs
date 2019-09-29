using EFCodeFirstInvoice.Services;
using EFCodeFirstInvoice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Repository
{
    public class ProductRepository : IProduct
    {
        private InvoiceDbContext db;

        public ProductRepository(InvoiceDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Product> GetProducts => db.Products;

        public void Create(Product model)
        {
            db.Products.Add(model);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            Product model = db.Products.Find(Id);
            db.Products.Remove(model);
            db.SaveChanges();
        }

        public Product GetProduct(int? Id)
        {
            Product model = db.Products.Find(Id);
            return model;
        }

        public void Update(Product model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
