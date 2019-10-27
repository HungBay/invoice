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
    public class BillDetailController : Controller
    {
        private readonly IBillDetail _billDetail;
        private readonly IBill _bill;
        private readonly IProduct _product;
        private readonly ICustomer _customer;
        public BillDetailController(IBillDetail billDetail, IBill bill, IProduct product, ICustomer customer)
        {
            _billDetail = billDetail;
            _bill = bill;
            _product = product;
            _customer = customer;
        }
        [HttpGet]
        public IActionResult Index(int? page, string searchString)
        {
            //return View("Index", _billDetail.GetBillDetails);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            if (searchString == null)
            {
                ViewBag.billDetail = _billDetail.GetBillDetails.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.billDetail);
            }
            else
            {
                //var model = from m in _billDetail.GetBillDetails select m;
                //model = model.Where(s => s.Product.Name.Contains(searchString));
                ViewBag.billDetailSearch = searchString;
                ViewBag.billDetail = _billDetail.GetBillDetails.Where(s => s.Product.Name.Contains(searchString)).ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.billDetail);
            }
        }


        [HttpGet]
        public IActionResult Details(Guid? Id)
        {
            return View("Details", _billDetail.GetBillDetail(Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Bills = _bill.GetBills;
            ViewBag.Products = _product.GetProducts;
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateProduct(BillDetail model)
        {
            if (ModelState.IsValid)
            {
                _billDetail.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                ViewBag.Bills = _bill.GetBills;
                ViewBag.Products = _product.GetProducts;
                return View(_billDetail.GetBillDetail(Id));
            }catch(Exception e)
            {
                return RedirectToAction("Index", e.Message);
            }
            
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditBillDetail(Guid? Id, [Bind("Id", "CreatedAt", "UpdateddAt", "status", "Quantity", "UnitPrice", "ProductId", "BillId")] BillDetail model)
        {
            _billDetail.Edit(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _bill.GetBill(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteBillDetail(Guid? Id)
        {
            _billDetail.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
