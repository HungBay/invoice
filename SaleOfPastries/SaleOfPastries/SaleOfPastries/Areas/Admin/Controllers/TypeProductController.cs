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
    public class TypeProductController : Controller
    {
        private readonly ITypeProduct _typeProduct;

        public TypeProductController(ITypeProduct typeProduct)
        {
            _typeProduct = typeProduct;
        }
        // GET: /<controller>/
        public IActionResult Index(int? page)
        {
            //return View("Index", _typeProduct.GetTypeProducts);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            ViewBag.typeProducts = _typeProduct.GetTypeProducts.ToList().ToPagedList(pageNumber, pageSize);
            return View(ViewBag.typeProducts);
        }

        [HttpGet]
        public IActionResult Details(Guid? Id)
        {
            return View("Details", _typeProduct.GetTypeProduct(Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateTypeProduct(TypeProduct model)
        {
            if (ModelState.IsValid)
            {
                _typeProduct.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                return View(_typeProduct.GetTypeProduct(Id));
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", e.Message);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditTypeProduct(Guid? Id, [Bind("Id", "CreatedAt", "UpdatedAt", "status", "Name", "Description", "Image")] TypeProduct model)
        {
            _typeProduct.Edit(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _typeProduct.GetTypeProduct(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteTypeProduct(Guid? Id)
        {
            _typeProduct.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
