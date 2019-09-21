using invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Services
{
    public interface IInvoice_details
    {
        IEnumerable<Invoice_details> GetInvoice_Details { get; }

        Invoice_details GetInvoice_Detail(int? Id);

        void Add(Invoice_details _Invoice_Details);

        void Remove(int? Id);

        void Update(Invoice_details _Invoice_Details);
    }
}
