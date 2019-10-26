using Microsoft.EntityFrameworkCore;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using SaleOfPastries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Reponsitory
{
    public class CustomerRepository : ICustomer
    {
        private SaleOfPastriesDbContext db;

        public CustomerRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<Customer> GetCustomers => db.Customers;

        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            Customer model = db.Customers.Find(Id);
            db.Customers.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid?Id, Customer customer)
        {
            Customer model = db.Customers.Find(Id);

            model.Name = customer.Name;
            model.Gender = customer.Gender;
            model.Email = customer.Email;
            model.Address = customer.Address;
            model.Phone = customer.Phone;
            model.Note = customer.Note;
            model.status = customer.status;

            model.UpdatedAt = DateTime.Now;

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Customer GetCustomer(Guid? Id)
        {
            Customer result = db.Customers.Find(Id);
            return result;
        }
    }
}
