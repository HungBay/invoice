using invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Services
{
    public interface IInvoice
    {
        IEnumerable<Invoice> GetInvoices { get; }

        Invoice GetInvoice(int? Id);

        void Add(Invoice _Invoice);

        void Remove(int? Id);

        void Update(Invoice _Invoice);
    }
}
