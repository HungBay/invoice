﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using X.PagedList;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleOfPastries.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillController : Controller
    {
        private readonly IBill _bill;
        private readonly ICustomer _customer;

        public BillController(IBill bill, ICustomer customer)
        {
            _bill = bill;
            _customer = customer;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(int? page, string searchString)
        {
            //return View("Index", _bill.GetBills);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            if (searchString == null)
            {
                ViewBag.bill = _bill.GetBills.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.bill);
            }
            else
            {
                var model = from m in _bill.GetBills select m;
                model = model.Where(s => s.Customer.Name.Contains(searchString));
                ViewBag.billSearch = searchString;

                ViewBag.bill = model.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.bill);
            }

        }
        [HttpGet]
        public IActionResult Details(Guid? Id)
        {
            return View("Details", _bill.GetBill(Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Customers = _customer.GetCustomers;
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateBill(Bill model)
        {
            if (ModelState.IsValid)
            {
                _bill.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                ViewBag.Customers = _customer.GetCustomers;
                return View(_bill.GetBill(Id));
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", e.Message);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditBill(Guid? Id, [Bind("Id", "CreatedAt", "UpdatedAt", "status", "DateOrder", "Total", "Note", "CustomerId")] Bill model)
        {
            _bill.Edit(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _bill.GetBill(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteBill(Guid? Id)
        {
            _bill.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}