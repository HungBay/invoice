using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvcApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvcApi.Controllers
{
    public class TypeProductController : Controller
    {
        private readonly EcommerceDbContext _context;

        public TypeProductController(EcommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var typeProduct = new List<TypeProduct>();
            var typeProductContext = _context.TypeProducts.ToList();
            if (typeProductContext != null)
            {
                typeProduct.AddRange(typeProductContext);
            }
            return View(typeProduct);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost, ActionName("Add")]
        public IActionResult AddTypeProduct(TypeProduct model)
        {
            var typeProduct = new TypeProduct() { Name = model.Name, Description = model.Description, Image = model.Image };
            if (typeProduct != null)
            {
                _context.TypeProducts.Add(typeProduct);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            return View(_context.TypeProducts.Where(x => x.Id == Id).FirstOrDefault());
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult UpdateTypeProduct(TypeProduct model)
        {
            var typeProduct = _context.TypeProducts.Where(x => x.Id == model.Id).FirstOrDefault();
            if (typeProduct != null)
            {
                typeProduct.Name = model.Name;
                typeProduct.UpdatedAt = DateTime.Now;
                _context.TypeProducts.Update(typeProduct);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            return View(_context.TypeProducts.Where(x => x.Id == Id).FirstOrDefault());
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteTypeProduct(TypeProduct model)
        {
            var typeProduct = _context.TypeProducts.Where(x => x.Id == model.Id).FirstOrDefault();
            if (typeProduct != null)
            {
                _context.TypeProducts.Remove(typeProduct);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}