using EFCodeFirstInvoice.Services;
using EFCodeFirstInvoice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Repository
{
    public class CustomerRepository : ICustomer
    {
        private InvoiceDbContext db;

        public CustomerRepository(InvoiceDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Customer> GetCustomers => db.Customers;

        public void Create(Customer model)
        {
            db.Customers.Add(model);
            db.SaveChanges();
        }

        public Customer GetCustomer(int? Id)
        {
            return db.Customers.Find(Id);
        }

        public void Delete(int? Id)
        {
            Customer dbEntity = db.Customers.Find(Id);
            db.Customers.Remove(dbEntity);
            db.SaveChanges();
        }

        public void Update(Customer model)
        {
            
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
