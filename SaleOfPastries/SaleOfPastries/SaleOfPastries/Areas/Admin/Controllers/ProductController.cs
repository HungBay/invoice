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
    public class ProductController : Controller
    {
        private readonly IProduct _product;

        private readonly ITypeProduct _typeProduct;

        public ProductController(IProduct product, ITypeProduct typeProduct)
        {
            _product = product;
            _typeProduct = typeProduct;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index", _product.GetProducts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.TypeProductId = _typeProduct.GetTypeProducts;
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
    }
}
