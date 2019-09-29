using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirstInvoice.Models.viewModel;
using EFCodeFirstInvoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirstInvoice.Controllers
{
    
    public class InvoiceCustomerController : Controller
    {
        private readonly IInvoiceCustomer _InvoiceCustomer;

        public InvoiceCustomerController(IInvoiceCustomer invoiceCustomer)
        {
            _InvoiceCustomer = invoiceCustomer;
        }

        
        public IActionResult Index()
        {
            return View(_InvoiceCustomer.GetInvoiceCustomers);
        }

        public IActionResult Details(int? Id)
        {
            IEnumerable<InvoiceView> model = _InvoiceCustomer.InvoiceCustomer(Id ?? 1);
            return View(model);
        }
    }
}