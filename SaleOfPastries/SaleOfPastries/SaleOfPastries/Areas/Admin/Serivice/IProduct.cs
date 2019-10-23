﻿using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts { get; }
        Product GetProduct(Guid? Id);
        void Add(Product product);
        void Edit(Guid? Id, Product product);
        void Delete(Guid? Id);
    }
}
