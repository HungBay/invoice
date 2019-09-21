using mvc_empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Services
{
    interface IInvoice
    {
        Invoice GetInvoice(int? Id);
        IEnumerable<Invoice> GetInvoices();
        void Create(Invoice invoice);
        void Update(Invoice invoice);
        void Delete(int? Id);
    }
}
