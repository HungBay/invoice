using EFCodeFirstInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Services
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts { get; }
        Product GetProduct(int? Id);
        void Create(Product model);
        void Update(Product model);
        void Delete(int? Id);
    }
}
