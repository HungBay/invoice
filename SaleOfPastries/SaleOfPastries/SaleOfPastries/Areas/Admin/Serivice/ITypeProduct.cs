using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface ITypeProduct
    {
        IEnumerable<TypeProduct> GetTypeProducts { get; }
        TypeProduct GetTypeProduct(Guid? Id);
        void Add(TypeProduct typeProduct);
        void Edit(Guid? Id, TypeProduct typeProduct);
        void Delete(Guid? Id);
    }
}
