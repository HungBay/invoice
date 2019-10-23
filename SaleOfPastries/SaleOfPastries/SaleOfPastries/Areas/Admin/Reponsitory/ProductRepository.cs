using Microsoft.EntityFrameworkCore;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using SaleOfPastries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Reponsitory
{
    public class ProductRepository : IProduct
    {
        private SaleOfPastriesDbContext db;

        public ProductRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }
        
        public IEnumerable<Product> GetProducts => db.Products.Include(x => x.TypeProduct);

        public void Add(Product product)
        {
            
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Guid? Id, Product product)
        {
            Product model = new Product();
            model.Name = product.Name;
            model.Description = product.Description;
            if (model.Image == null)
            {
                model.Image = model.Image;
            }

            model.status = product.status;
            model.UpdatedAt = DateTime.Now;
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Product GetProduct(Guid? Id)
        {
            Product model = db.Products.Where(x => x.Id == Id).FirstOrDefault();
            return model;
        }
    }
}
