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
    public class NewProductController : Controller
    {
        private readonly INewProduct _newProduct;

        public NewProductController(INewProduct newProduct)
        {
            _newProduct = newProduct;
        }
        // GET: /<controller>/
        public IActionResult Index(int? page)
        {
            //return View("Index", _newProduct.GetNewProducts);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            ViewBag.typeProducts = _newProduct.GetNewProducts.ToList().ToPagedList(pageNumber, pageSize);
            return View(ViewBag.typeProducts);
        }

        [HttpGet]
        public IActionResult Details(Guid? Id)
        {
            return View("Details", _newProduct.GetNewProduct(Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateNewProduct(NewProduct model)
        {
            if (ModelState.IsValid)
            {
                _newProduct.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                return View(_newProduct.GetNewProduct(Id));
            }catch(Exception e)
            {
                return RedirectToAction("Index", e.Message);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditNewProduct(Guid? Id, [Bind("Id", "CreatedAt", "UpdatedAt", "status", "Title", "Context", "Image")] NewProduct model)
        {
            _newProduct.Edit(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _newProduct.GetNewProduct(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteNewProduct(Guid? Id)
        {
            _newProduct.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
