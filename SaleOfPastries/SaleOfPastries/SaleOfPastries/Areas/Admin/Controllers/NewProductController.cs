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
        [HttpGet]
        public IActionResult Index(int? page, string searchString)
        {
            //return View("Index", _newProduct.GetNewProducts);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            if (searchString == null)
            {
                ViewBag.newProducts = _newProduct.GetNewProducts.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.newProducts);
            }
            else
            {
                var model = from m in _newProduct.GetNewProducts select m;
                model = model.Where(s => s.Title.Contains(searchString));
                ViewBag.newProductSearch = searchString;

                ViewBag.newProducts = model.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.newProducts);
            }

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
