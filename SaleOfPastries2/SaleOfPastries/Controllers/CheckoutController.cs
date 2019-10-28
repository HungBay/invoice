using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Helpers;
using SaleOfPastries.Models;

namespace SaleOfPastries.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IProduct _Product;

        private readonly ITypeProduct _TypeProduct;

        private readonly ICustomer _Customer;

        private readonly IBill _Bill;

        private readonly IBillDetail _BillDetail;
        public CheckoutController(IProduct product, ITypeProduct typeProduct, ICustomer customer, IBill bill, IBillDetail billDetail)
        {
            _Product = product;
            _TypeProduct = typeProduct;
            _Customer = customer;
            _Bill = bill;
            _BillDetail = billDetail;
        }

        public IActionResult Index()
        {
            //header
            ViewBag.TypeProducts = _TypeProduct.GetTypeProducts;

            List<BillDetail> cart = SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart");

            ViewBag.CartCheckOut = cart;
            if (cart != null)
            {
                ViewBag.total = cart.Sum(item => item.Product.UnitPrice * item.Quantity);
            }
            else
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Order(Customer model)
        {

            List<BillDetail> cart = SessionHelper.GetObjectFromJson<List<BillDetail>>(HttpContext.Session, "cart");
            ViewBag.SuccessOrder = false;
            ViewBag.CartCheckOut = cart;
            if (cart != null)
            {
                ViewBag.total = cart.Sum(item => item.Product.UnitPrice * item.Quantity);
                _Customer.Add(model);
                //new bill
                Bill modelBill = new Bill();
                modelBill.CustomerId = model.Id;
                modelBill.DateOrder = DateTime.Now;
                modelBill.Total = ViewBag.total;
                _Bill.Add(modelBill);

                //new Bill details
                for (int i = 0; i < cart.Count(); i++)
                {
                    BillDetail newBillDetails = new BillDetail();
                    newBillDetails.Quantity = cart[i].Quantity;
                    newBillDetails.UnitPrice = cart[i].Product.UnitPrice;
                    newBillDetails.ProductId = cart[i].Product.Id;
                    newBillDetails.BillId = modelBill.Id;
                    _BillDetail.Add(newBillDetails);
                }
                ViewBag.SuccessOrder = true;
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
    }
}