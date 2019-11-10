using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvcApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMvcApi.Controllers
{
    public class ProductController : Controller
    {
        private readonly EcommerceDbContext _context;

        public ProductController(EcommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var product = new List<Product>();
            var productContext = _context.Products.ToList();
            if (productContext != null)
            {
                product.AddRange(productContext);
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Add()
        {

            ViewBag.TypeProduct = _context.TypeProducts.ToList();
            return View();
        }

        [HttpPost, ActionName("Add")]
        public IActionResult Addproduct(Product model)
        {
            
            var product = new Product() { Name = model.Name, Description = model.Description, UnitPrice = model.UnitPrice, PromotionPrice = model.PromotionPrice, TypeProductId = model.TypeProductId, Unit = model.Unit, New = model.New };
            if (product != null)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            ViewBag.TypeProduct = _context.TypeProducts.ToList();
            return View(_context.Products.Where(x => x.Id == Id).FirstOrDefault());
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult Updateproduct(Product model)
        {
            var product = _context.Products.Where(x => x.Id == model.Id).FirstOrDefault();
            if (product != null)
            {
                product.Name = model.Name;
                product.UpdatedAt = DateTime.Now;
                _context.Products.Update(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}