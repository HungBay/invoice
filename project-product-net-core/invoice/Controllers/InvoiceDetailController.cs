using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace invoice.Controllers
{
    public class InvoiceDetailController : Controller
    {
        private readonly IInvoice_details _InvoiceDetail;

        private readonly IInvoice _Invoice;

        private readonly IProduct _Product;

        public InvoiceDetailController(IInvoice_details _IInvoiceDetail, IInvoice _IInvoice, IProduct _IProduct)
        {
            _InvoiceDetail = _IInvoiceDetail;
            _Invoice = _IInvoice;
            _Product = _IProduct;
        }

        public IActionResult Index()
        {
            return View(_InvoiceDetail.GetInvoice_Details);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Invoices = _Invoice.GetInvoices;
            ViewBag.Products = _Product.GetProducts;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Invoice_details model)
        {
            if (ModelState.IsValid)
            {
                _InvoiceDetail.Add(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id != null)
            {
                Invoice_details model = _InvoiceDetail.GetInvoice_Detail(Id??1);
               
                return View(model);
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
                Invoice_details model = _InvoiceDetail.GetInvoice_Detail(Id);
                ViewBag.Invoices = _Invoice.GetInvoices;
                ViewBag.Products = _Product.GetProducts;
                return View(model);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost([Bind("ID_CTHD", "ID_HOADON", "ID_SP","SOLUONG","THANHTIEN")] Invoice_details invoice_Details)
        {
            _InvoiceDetail.Update(invoice_Details);
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
                Invoice_details model = _InvoiceDetail.GetInvoice_Detail(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _InvoiceDetail.Remove(Id);
            return RedirectToAction("index");
        }
    }
}