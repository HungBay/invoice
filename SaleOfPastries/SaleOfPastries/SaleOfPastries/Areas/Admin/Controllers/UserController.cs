﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleOfPastries.Areas.Admin.Serivice;
using SaleOfPastries.Models;
using SaleOfPastries.Repositories;
using X.PagedList;

namespace SaleOfPastries.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        //private SaleOfPastriesDbContext db;

        //public UserController(SaleOfPastriesDbContext _db)
        //{
        //    db = _db;
        //}
        private readonly IUser _User;

        public UserController(IUser user)
        {
            _User = user;
        }
        //[Route("user")]
        //[Route("")]
        //[Route("~/")]
     
        //public IActionResult Index()
        //{
        //    return View(_User.GetUsers);
        //}

       
        public IActionResult Index(int? page)
        {
            int pageSize = 2;
            var pageNumber = page ?? 1;
            ViewBag.users = _User.GetUsers.ToList().ToPagedList(pageNumber, pageSize);
            return View(ViewBag.users);
        }

        //public IActionResult Index(User model)
        //{
        //    if (!string.IsNullOrEmpty(model.Text))
        //    {
        //        model.Text = _User.GetUsers.FullTe
        //    }
        //    else
        //    {
        //        model.Uses = _User.GetUsers;
        //    }
        //    return View(model);
        //}

        [HttpGet]
        public IActionResult Details(Guid? Id)
        {
            return View("Details",_User.GetUser(Id));
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
        public IActionResult Edit(Guid? Id,[Bind("Id","CreatedAt","UpdatedAt","status","FullName","Email","Password","Phone","Address", "Image")] User model)
        {
            _User.Edit(Id,model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid? Id)
        {
            return View("Delete", _User.GetUser(Id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteUser(Guid? Id)
        {
            _User.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}