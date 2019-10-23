using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;

namespace SaleOfPastries.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _Product;

        private readonly ITypeProduct _TypeProduct;

        public ProductController(IProduct product, ITypeProduct typeProduct)
        {
            _Product = product;
            _TypeProduct = typeProduct;
        }
        public IActionResult Index(Guid? Id)
        {
            ViewBag.TypeProducts = _TypeProduct.GetTypeProducts;
            return View("Index", _Product.GetProduct(Id));
        }
    }
}