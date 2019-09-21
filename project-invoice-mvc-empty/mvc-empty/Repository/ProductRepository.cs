using mvc_empty.Models;
using mvc_empty.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Repository
{
    public class ProductRepository : IProduct
    {
        private List<Product> _productList;

        public ProductRepository()
        {
            _productList = new List<Product>()
            {
                new Product() {ID_SP=1, MOTA_SP="Quan ao dep", GIA=1000000,SOLUONG=10},
                new Product() {ID_SP=2, MOTA_SP="Quan ao dep 2", GIA=1000000,SOLUONG=20},
                new Product() {ID_SP=3, MOTA_SP="Quan ao dep 3", GIA=1000000,SOLUONG=30},
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return _productList.ToList();
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int? Id)
        {
            return _productList.FirstOrDefault(x => x.ID_SP == Id);
        }

        

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
