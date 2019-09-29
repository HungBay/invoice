using EFCodeFirstInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Services
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers { get; }
        Customer GetCustomer(int? Id);
        void Create(Customer model);
        void Update(Customer model);
        void Delete(int? Id);
    }
}
