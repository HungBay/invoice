using Microsoft.EntityFrameworkCore;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using SaleOfPastries.Models.viewModel;
using SaleOfPastries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Reponsitory
{
    public class BillDetailRepository : IBillDetail
    {
        private SaleOfPastriesDbContext db;

        public BillDetailRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<BillDetail> GetBillDetails => db.BillDetails.Include(x => x.Bill).Include(y => y.Product);


        public void Add(BillDetail billDetail)
        {
            db.BillDetails.Add(billDetail);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            BillDetail model = db.BillDetails.Find(Id);
            db.BillDetails.Remove(model);
            db.SaveChanges();
        }

        public void Edit(Guid? Id, BillDetail billDetail)
        {
            BillDetail model = db.BillDetails.Find(Id);

            model.BillId = billDetail.BillId;
            model.ProductId = billDetail.ProductId;
            model.Quantity = billDetail.Quantity;
            //model.UnitPrice = billDetail.UnitPrice;
            model.status = billDetail.status;

            model.UpdatedAt = DateTime.Now;

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public BillDetail GetBillDetail(Guid? Id)
        {
            BillDetail model = db.BillDetails.Find(Id);
            return model;
        }

        //
        //public IEnumerable<BillDetailView> GetBillDetailView(Guid? Id)
        //{
        //    var model = db.BillDetails.Where(s => s.BillId == Id).ToList();
            
        //}
    }
}
