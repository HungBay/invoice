using System;
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
    public class CustomerController : Controller
    {
        private readonly ICustomer _Customer;

        public CustomerController(ICustomer customer)
        {
            _Customer = customer;
        }
        // GET: /<controller>/
        public IActionResult Index(int? page)
        {
            //return View("Index", _Customer.GetCustomers);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            ViewBag.typeProducts = _Customer.GetCustomers.ToList().ToPagedList(pageNumber, pageSize);
            return View(ViewBag.typeProducts);
        }

        [HttpGet]
        public IActionResult Details(Guid? Id)
        {
            return View("Details", _Customer.GetCustomer(Id));
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateCustomer(Customer model)
        {
            if (ModelState.IsValid)
            {
                _Customer.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                return View(_Customer.GetCustomer(Id));
            }catch(Exception e)
            {
                return RedirectToAction("Index", e.Message);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditCustomer(Guid? Id, [Bind("Id", "CreatedAt", "UpdateAt", "status", "Name", "Gender", "Email", "Address", "Phone", "Note")] Customer model)
        {
            _Customer.Edit(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _Customer.GetCustomer(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCustomer(Guid? Id)
        {
            _Customer.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
