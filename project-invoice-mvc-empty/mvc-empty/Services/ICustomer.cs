using mvc_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Services
{
    interface ICustomer
    {
        Customer GetCustomer(int? Id);
        IEnumerable<Customer> GetCustomers();
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(int? Id);
    }
}
