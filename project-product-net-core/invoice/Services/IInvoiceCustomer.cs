using invoice.Models.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Services
{
    public interface IInvoiceCustomer
    {
        InvoiceView InvoiceCustomer(int? Id);
        IEnumerable<InvoiceView> GetInvoiceCustomers { get; }


    }
}
