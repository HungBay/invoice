using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace invoice.Controllers
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
            return View(_InvoiceCustomer.InvoiceCustomer(Id ?? 1));
        }
    }
}