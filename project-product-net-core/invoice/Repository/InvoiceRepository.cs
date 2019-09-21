using invoice.Models;
using invoice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace invoice.Repository
{
    public class InvoiceRepository : IInvoice
    {
        private DB_Context db;

        public InvoiceRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Invoice> GetInvoices => db.Invoices.Include(x => x.Customers);

        public void Add(Invoice _Invoice)
        {
            db.Invoices.Add(_Invoice);
            db.SaveChanges();
        }

        public Invoice GetInvoice(int? Id)
        {
            return db.Invoices.Find(Id);
        }

        public void Remove(int? Id)
        {
            Invoice dbEntity = db.Invoices.Find(Id);
            db.Invoices.Remove(dbEntity);
            db.SaveChanges();
        }

        public void Update(Invoice _Invoice)
        {
            db.Entry(_Invoice).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
