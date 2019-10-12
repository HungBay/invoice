using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models.viewModel;

namespace invoice.Services
{
    public interface IInvoiceList
    {
        invoiceView ListInvoice(int? Id);
        IEnumerable<invoiceView> ListALL { get; }
    }
}
