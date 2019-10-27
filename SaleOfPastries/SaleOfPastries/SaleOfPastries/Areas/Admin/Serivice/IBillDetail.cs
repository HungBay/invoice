using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleOfPastries.Models.viewModel;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface IBillDetail
    {
        IEnumerable<BillDetail> GetBillDetails { get; }
        BillDetail GetBillDetail(Guid? Id);
        void Add(BillDetail billDetail);
        void Edit(Guid? Id, BillDetail billDetail);
        void Delete(Guid? Id);

        //BillDetailsView
        //IEnumerable<BillDetailView> GetBillDetailView(Guid? Id);
    }
}
