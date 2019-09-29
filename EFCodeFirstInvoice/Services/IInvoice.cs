using EFCodeFirstInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Services
{
    public interface IInvoice
    {
        IEnumerable<Invoice> GetInvoices { get; }
        Invoice GetInvoice(int? Id);
        void Create(Invoice model);
        void Update(Invoice model);
        void Delete(int? Id);
    }
}
