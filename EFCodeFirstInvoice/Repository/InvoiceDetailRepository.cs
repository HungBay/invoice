using EFCodeFirstInvoice.Services;
using EFCodeFirstInvoice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Repository
{
    public class InvoiceDetailRepository : IInvoiceDetail
    {
        private InvoiceDbContext db;

        public InvoiceDetailRepository(InvoiceDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Invoice_detail> GetInvoiceDetails => db.Invoice_details;

        public void Create(Invoice_detail model)
        {
            db.Invoice_details.Add(model);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            db.Invoice_details.Remove(db.Invoice_details.Find(Id));
            db.SaveChanges();
        }

        public Invoice_detail GetInvoiceDetail(int? Id)
        {
            return db.Invoice_details.Find(Id);
        }

        public void Update(Invoice_detail model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
