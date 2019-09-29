using EFCodeFirstInvoice.Models.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Services
{
    public interface IInvoiceCustomer
    {
        IEnumerable<InvoiceView> InvoiceCustomer(int? Id);
        IEnumerable<InvoiceView> GetInvoiceCustomers { get; }
    }
}
