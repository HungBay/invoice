using invoice.Models;
using invoice.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Repository
{
    public class ProductRepository : IProduct
    {
        private DB_Context db;

        public ProductRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Product> GetProducts => db.Products;

        public void Add(Product _Product)
        {
            db.Products.Add(_Product);
            db.SaveChanges();
        }

        public Product GetProduct(int? Id)
        {
            Product dbEntity = db.Products.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Product dbEntity = db.Products.Find(Id);
            db.Products.Remove(dbEntity);
            db.SaveChanges();
        }

        public void Update(Product _Product)
        {            
            db.Entry(_Product).State = EntityState.Modified;
            db.SaveChanges();
        }

       
    }
}
