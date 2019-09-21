using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_empty.Models;
using mvc_empty.Services;

namespace mvc_empty.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _product;

        public HomeController(IProduct product)
        {
            _product = product;
        }

        public ViewResult Index()
        {
            var model = _product.GetProducts();
            return View(model);
        }

        public ViewResult Details(int? Id)
        {
            Product model = _product.GetProduct(Id??1);
            return View(model);
        }
    }
}