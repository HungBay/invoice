using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace invoice.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _customer;

        public CustomerController(ICustomer _Icustomer)
        {
            _customer = _Icustomer;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_customer.GetCustomers);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                _customer.Add(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id != null)
            {
                return View(_customer.GetCustomer(Id));
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
                Customer model = _customer.GetCustomer(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost([Bind("ID_KHACHHANG", "TEN_KHACH_HANG", "DIA_CHI_KHACH_HANG")] Customer customer)
        {
            _customer.Update(customer);
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
                Customer model = _customer.GetCustomer(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _customer.Remove(Id);
            return RedirectToAction("index");
        }
    }
}