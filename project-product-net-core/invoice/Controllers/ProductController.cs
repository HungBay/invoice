using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace invoice.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _Product;

        public ProductController(IProduct _IProduct)
        {
            _Product = _IProduct;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_Product.GetProducts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                _Product.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id != null)
            {
                return View(_Product.GetProduct(Id));
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
                Product model = _Product.GetProduct(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost([Bind("ID_SP","MOTA_SP","GIA","SOLUONG")] Product product)
        {
            _Product.Update(product);
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
                Product model = _Product.GetProduct(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Product.Remove(Id);
            return RedirectToAction("index");
        }
    }
}