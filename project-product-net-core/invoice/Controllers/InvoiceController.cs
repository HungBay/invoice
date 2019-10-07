using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace invoice.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoice _Invoice;

        private readonly ICustomer _Customer;

        public InvoiceController(IInvoice _IInvoice, ICustomer _ICustomer)
        {
            _Customer = _ICustomer;
            _Invoice = _IInvoice;
        }

        public IActionResult Index()
        {
            return View(_Invoice.GetInvoices);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Customers = _Customer.GetCustomers;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Invoice model)
        {
            if (ModelState.IsValid)
            {
                _Invoice.Add(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id != null)
            {
                return View(_Invoice.GetInvoice(Id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Invoice model = _Invoice.GetInvoice(Id);
                ViewBag.Customers = _Customer.GetCustomers;
                return View(model);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost([Bind("ID_HOADON", "ID_KHACHHANG", "NGAYBAN")] Invoice invoice)
        {
            _Invoice.Update(invoice);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Invoice model = _Invoice.GetInvoice(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Invoice.Remove(Id);
            return RedirectToAction("index");
        }
    }
}