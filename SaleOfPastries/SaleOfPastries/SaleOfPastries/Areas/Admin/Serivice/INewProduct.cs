using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface INewProduct
    {
        IEnumerable<NewProduct> GetNewProducts { get; }
        NewProduct GetNewProduct(Guid? Id);
        void Add(NewProduct newProduct);
        void Edit(Guid? Id, NewProduct newProduct);
        void Delete(Guid? Id);
    }
}
