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
    public class TypeProductRepository : ITypeProduct
    {
        private SaleOfPastriesDbContext db;

        public TypeProductRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<TypeProduct> GetTypeProducts => db.TypeProducts;

        public void Add(TypeProduct typeProduct)
        {
            db.TypeProducts.Add(typeProduct);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            TypeProduct model = db.TypeProducts.Find(Id);
            db.TypeProducts.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, TypeProduct typeProduct)
        {
            TypeProduct model = db.TypeProducts.Find(Id);

            model.Name = typeProduct.Name;
            model.Description = typeProduct.Description;
            
            if(typeProduct.Image == null)
            {
                model.Image = model.Image;
            }
            else
            {
                model.Image = typeProduct.Image;
            }
            model.status = typeProduct.status;
            model.UpdatedAt = DateTime.Now;

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

        }

        public TypeProduct GetTypeProduct(Guid? Id)
        {
            TypeProduct result = db.TypeProducts.Find(Id);
            return result;
        }
    }
}
