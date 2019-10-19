using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;

namespace SaleOfPastries.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUser _User;

        public UserController(IUser user)
        {
            _User = user;
        }

        public IActionResult Index()
        {
            return View(_User.GetUsers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                _User.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            try
            {
                return View(_User.GetUser(Id));
            }
            catch(Exception e)
            {
                return RedirectToAction("Index", e.Message);
            }
            
        }
        [HttpPost]
        public IActionResult Edit(Guid? Id,[Bind("Id","CreateAt","UpdateAt","status","FullName","Email","Password","Phone","Address")] User model)
        {
            _User.Edit(Id,model);
            return RedirectToAction("Index");
        }
    }
}