using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Helpers;
using SaleOfPastries.Models;
using SaleOfPastries.Repositories;
namespace SaleOfPastries.Controllers
{
    public class CartController : Controller
    {
        private readonly SaleOfPastriesDbContext db;

        private readonly ITypeProduct _TypeProduct;

        public CartController(SaleOfPastriesDbContext _db, ITypeProduct TypeProduct)
        {
            db = _db;
            _TypeProduct = TypeProduct;
        }
        public IActionResult Index()
        {
            ViewBag.TypeProducts = _TypeProduct.GetTypeProducts;
            var cart = SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if(cart != null)
            {
                ViewBag.total = cart.Sum(item => item.Product.UnitPrice * item.Quantity);
            }
            else
            {
                return NotFound();
            }
            
            return View();
        }

        public IActionResult Buy(Guid? Id)
        {
            if (SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart") == null)
            {
                List<BillDetail> cart = new List<BillDetail>();
                cart.Add(new BillDetail { Product = db.Products.Find(Id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<BillDetail> cart = SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart");
                int index = isExist(Id);
                if(index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new BillDetail { Product = db.Products.Find(Id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(Guid? Id)
        {
            List<BillDetail> cart = SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart");
            int index = isExist(Id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(Guid? Id)
        {
            List<BillDetail> cart = SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(Id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}