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
    public class ProductController : Controller
    {
        private readonly IProduct _product;

        private readonly ITypeProduct _typeProduct;

        private readonly INewProduct _newProduct;

        public ProductController(IProduct product, ITypeProduct typeProduct, INewProduct newProduct)
        {
            _product = product;
            _typeProduct = typeProduct;
            _newProduct = newProduct;

        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(int? page, string searchString)
        {
            //return View("Index", _product.GetProducts);
            int pageSize = 2;
            var pageNumber = page ?? 1;
            if (searchString == null)
            {
                ViewBag.products = _product.GetProducts.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.products);
            }
            else
            {
                var model = from m in _product.GetProducts select m;
                model = model.Where(s => s.Name.Contains(searchString));
                ViewBag.productSearch = searchString;

                ViewBag.products = model.ToList().ToPagedList(pageNumber, pageSize);
                return View(ViewBag.products);
            }

        }

        [HttpGet]
        public IActionResult Details (Guid? Id)
        {
            return View("Details", _product.GetProduct(Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.TypeProducts = _typeProduct.GetTypeProducts;
            ViewBag.NewProducts = _newProduct.GetNewProducts;
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreateProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                _product.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                ViewBag.TypeProducts = _typeProduct.GetTypeProducts;
                ViewBag.NewProducts = _newProduct.GetNewProducts;
                return View(_product.GetProduct(Id));
            }catch(Exception e)
            {
                return View("Index", e.Message);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditProduct(Guid? Id, Product model)
        {
            _product.Edit(Id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _product.GetProduct(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteProduct(Guid? Id)
        {
            _product.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
