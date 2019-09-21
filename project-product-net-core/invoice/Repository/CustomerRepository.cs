using invoice.Models;
using invoice.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Repository
{
    public class CustomerRepository : ICustomer
    {
        private DB_Context db;

        public CustomerRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Customer> GetCustomers => db.Customers;

        public void Add(Customer _Customer)
        {
            db.Customers.Add(_Customer);
            db.SaveChanges();
        }

        public Customer GetCustomer(int? Id)
        {
            return db.Customers.Find(Id);
        }

        public void Remove(int? Id)
        {
            Customer dbEntity = db.Customers.Find(Id);
            db.Customers.Remove(dbEntity);
            db.SaveChanges();
        }

        public void Update(Customer _Customer)
        {
            db.Entry(_Customer).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
