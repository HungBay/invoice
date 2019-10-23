using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Services;
namespace SaleOfPastries.Controllers
{
    public class TypeProductController : Controller
    {
        private readonly SaleOfPastries.Services.IProduct _Product;

        private readonly ITypeProduct _TypeProduct;

        public TypeProductController(SaleOfPastries.Services.IProduct product, ITypeProduct typeProduct)
        {
            _Product = product;
            _TypeProduct = typeProduct;
        }
        public IActionResult Index(Guid? Id)
        {
            //header 
            ViewBag.TypeProducts = _TypeProduct.GetTypeProducts;

            ViewBag.TypeProductsByIdProduct = _TypeProduct.GetTypeProduct(Id);
            ViewBag.Products = _Product.GetProductByTypeProductId(Id);
            return View("Index", _TypeProduct.GetTypeProducts);
        }
    }
}