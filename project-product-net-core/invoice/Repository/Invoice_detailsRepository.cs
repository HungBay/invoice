using invoice.Models;
using invoice.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Repository
{
    public class Invoice_detailsRepository : IInvoice_details
    {
        private DB_Context db;

        public Invoice_detailsRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Invoice_details> GetInvoice_Details => db.Invoice_details;

        public void Add(Invoice_details _Invoice_Details)
        {
            db.Invoice_details.Add(_Invoice_Details);
            db.SaveChanges();
        }

        public Invoice_details GetInvoice_Detail(int? Id)
        {
            return db.Invoice_details.Find(Id);
        }

        public void Remove(int? Id)
        {
            db.Invoice_details.Remove(db.Invoice_details.Find
                (Id));
            db.SaveChanges();
        }

        public void Update(Invoice_details _Invoice_Details)
        {
            db.Entry(_Invoice_Details).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
