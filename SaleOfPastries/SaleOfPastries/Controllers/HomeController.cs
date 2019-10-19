using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Models;
using SaleOfPastries.Services;

namespace SaleOfPastries.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _Product;

        public HomeController(IProduct product)
        {
            _Product = product;
        }

        public IActionResult Index()
        {
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