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
    public class BillRepository : IBill
    {
        private SaleOfPastriesDbContext db;

        public BillRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<Bill> GetBills => db.Bills.Include(x => x.Customer);

        public void Add(Bill bill)
        {
            db.Bills.Add(bill);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            Bill model = db.Bills.Find(Id);
            db.Bills.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, Bill bill)
        {
            Bill model = db.Bills.Find(Id);

            model.CustomerId = bill.CustomerId;
            model.DateOrder = bill.DateOrder;
            model.Total = bill.Total;
            model.Note = bill.Note;

            model.UpdatedAt = DateTime.Now;

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Bill GetBill(Guid? Id)
        {
            Bill result = db.Bills.Find(Id);
            return result;
        }
    }
}
