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
    public class NewProductRepository : INewProduct
    {
        private SaleOfPastriesDbContext db;

        public NewProductRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<NewProduct> GetNewProducts => db.NewProducts;

        public void Add(NewProduct newProduct)
        {
            db.NewProducts.Add(newProduct);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            NewProduct model = db.NewProducts.Find(Id);
            db.NewProducts.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, NewProduct newProduct)
        {
            NewProduct model = db.NewProducts.Find(Id);

            model.Title = newProduct.Title;
            model.Context = newProduct.Context;
            
            if (newProduct.Image == null)
            {
                model.Image = model.Image;
            }
            else
            {
                model.Image = newProduct.Image;
            }
            model.status = newProduct.status;
            model.UpdatedAt = DateTime.Now;

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public NewProduct GetNewProduct(Guid? Id)
        {
            NewProduct result = db.NewProducts.Find(Id);
            return result;
        }
    }
}
