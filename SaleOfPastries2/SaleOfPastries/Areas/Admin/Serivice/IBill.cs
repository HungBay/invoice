using SaleOfPastries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Areas.Admin.Serivice
{
    public interface IBill
    {
        IEnumerable<Bill> GetBills { get; }
        Bill GetBill(Guid? Id);
        void Add(Bill bill);
        void Edit(Guid? Id, Bill bill);
        void Delete(Guid? Id);
    }
}
