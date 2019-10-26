using SaleOfPastries.Models;
using SaleOfPastries.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Repositories
{
    public class ProductRepository : IProduct
    {
        private SaleOfPastriesDbContext db;

        public ProductRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Product> GetProducts => db.Products;

        public Product GetProduct(Guid? Id)
        {
            Product model = db.Products.Where(x => x.Id == Id).FirstOrDefault();
            return model;
        }

        public IEnumerable<Product> GetProductByTypeProductId(Guid? Id)
        {
            var model = db.Products.Where(x => x.TypeProductId == Id).ToList();
            return model;
        }

        
    }
}
