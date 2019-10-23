using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using SaleOfPastries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Reponsitory
{
    public class BillDetailRepository : IBillDetail
    {
        private readonly SaleOfPastriesDbContext db;

        public BillDetailRepository(SaleOfPastriesDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<BillDetail> GetBillDetails => db.BillDetails;

        public void Add(BillDetail billDetail)
        {
            db.BillDetails.Add(billDetail);
            db.SaveChanges();
        }

        public void Delete(Guid? Id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Guid? Id, BillDetail billDetail)
        {
            throw new NotImplementedException();
        }

        public BillDetail GetBillDetail(Guid? Id)
        {
            throw new NotImplementedException();
        }
    }
}
