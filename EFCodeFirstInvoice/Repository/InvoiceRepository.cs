using EFCodeFirstInvoice.Services;
using EFCodeFirstInvoice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Repository
{
    public class InvoiceRepository : IInvoice
    {
        private InvoiceDbContext db;

        public InvoiceRepository(InvoiceDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Invoice> GetInvoices => db.Invoices;

        public void Create(Invoice model)
        {
            db.Invoices.Add(model);
            db.SaveChanges();
        }

        public Invoice GetInvoice(int? Id)
        {
            return db.Invoices.Find(Id);
        }

        public void Delete(int? Id)
        {
            Invoice dbEntity = db.Invoices.Find(Id);
            db.Invoices.Remove(dbEntity);
            db.SaveChanges();
        }

        public void Update(Invoice model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
