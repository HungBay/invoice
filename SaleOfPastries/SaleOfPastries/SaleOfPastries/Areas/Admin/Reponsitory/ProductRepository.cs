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
        
        public IEnumerable<Product> GetProducts => db.Products.Include(x => x.TypeProduct).Include(y => y.NewProduct);

        public void Add(Product product)
        {   
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            Product model = db.Products.Find(Id);
            db.Products.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, Product product)
        {
            Product model = db.Products.Find(Id);

            model.Name = product.Name;
            model.Description = product.Description;
            if (product.Image == null)
            {
                model.Image = model.Image;
            }
            else
            {
                model.Image = product.Image;
            }
            model.Unit = product.Unit;
            model.UnitPrice = product.UnitPrice;
            model.PromotionPrice = product.PromotionPrice;
            model.TypeProductId = product.TypeProductId;
            model.NewId = product.NewId;
            model.status = product.status;

            model.UpdatedAt = DateTime.Now;
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Product GetProduct(Guid? Id)
        {
            //Product model = db.Products.Where(x => x.Id == Id).FirstOrDefault();
            Product model = db.Products.Find(Id);
            return model;
        }


        //view user
        public IEnumerable<Product> GetProductsPage(int? Page)
        {
            const int PAGE_SIZE = 8;

            if (Page == null) Page = 1;
            int skipN = (Page.Value - 1) * PAGE_SIZE;

            var model = db.Products.OrderByDescending(p => p.Id).Skip(skipN).Take(PAGE_SIZE).ToList();

            return model;
        }

        public IEnumerable<Product> GetProductsRelated(Guid? Id)
        {
            var model = db.Products.Where(x => x.TypeProductId == Id).ToList();
            return model;
        }

        public IEnumerable<Product> GetProductsNew(int Id)
        {
            var model = db.Products.Where(x => x.New == Id).ToList();
            return model;
        }

        public IEnumerable<Product> GetProductsSearch(string s)
        {
            var model = db.Products.Where(x => x.Name.Contains(s));
            return model;
        }
    }
}
