using mvc_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Services
{
    interface IInvoiceDetails
    {
        InvoiceDetails GetInvoiceDetails(int? Id);
        IEnumerable<InvoiceDetails> GetInvoiceDetails();
        void Create(InvoiceDetails invoiceDetails);
        void Update(InvoiceDetails invoiceDetails);
        void Delete(int? Id);
    }
}
