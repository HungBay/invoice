using mvc_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Services
{
    public interface IProduct
    {
        Product GetProduct(int? Id);
        IEnumerable<Product> GetProducts();
        void Create(Product product);
        void Update(Product product);
        void Delete(int? Id);
    }
}
