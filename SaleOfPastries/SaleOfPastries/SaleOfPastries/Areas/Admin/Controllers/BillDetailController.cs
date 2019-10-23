using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleOfPastries.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillDetailController : Controller
    {
        private readonly IBillDetail _billDetail;

        public BillDetailController(IBillDetail billDetail)
        {
            _billDetail = billDetail;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index", _billDetail.GetBillDetails);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateBillDetail(BillDetail model)
        {
            _billDetail.Add(model);
            return RedirectToAction("Index");
        }
    }
}
