using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers { get; }
        Customer GetCustomer(Guid? Id);
        void Add(Customer customer);
        void Edit(Guid? Id, Customer customer);
        void Delete(Guid? Id);
    }
}
