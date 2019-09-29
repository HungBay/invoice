using EFCodeFirstInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Services
{
    public interface IInvoiceDetail
    {
        IEnumerable<Invoice_detail> GetInvoiceDetails { get; }
        Invoice_detail GetInvoiceDetail(int? Id);
        void Create(Invoice_detail model);
        void Update(Invoice_detail model);
        void Delete(int? Id);
    }
}
