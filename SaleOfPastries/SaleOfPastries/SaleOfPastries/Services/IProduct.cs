using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Services
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts { get; }
        Product GetProduct(Guid? Id);
        IEnumerable<Product> GetProductByTypeProductId(Guid? Id);
    }
}
