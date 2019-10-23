using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
//using SaleOfPastries.Services;

namespace SaleOfPastries.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _Product;

        private readonly ITypeProduct _TypeProduct;

        public HomeController(IProduct product, ITypeProduct typeProduct)
        {
            _Product = product;
            _TypeProduct = typeProduct;
        }

        public IActionResult Index()
        {
            ViewBag.TypeProducts = _TypeProduct.GetTypeProducts;
            return View("Index", _Product.GetProducts);
        }
        
        [HttpGet]
        public IActionResult Detail(Guid? Id)
        {
            Product model = _Product.GetProduct(Id);
            if (Id==null || model==null)
            {
                return View(model);
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}