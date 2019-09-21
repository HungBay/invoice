using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvc_empty.Controllers
{
    public class InvoiceDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}