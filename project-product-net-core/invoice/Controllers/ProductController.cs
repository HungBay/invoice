using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.HtmlToPdf;
using Syncfusion.HtmlConverter;
using Microsoft.AspNetCore.Hosting;
using Rotativa.AspNetCore;

namespace invoice.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _Product;



        public ProductController(IProduct _IProduct)
        {
            _Product = _IProduct;
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_Product.GetProducts);
        }

        
        public IActionResult ExportToPDF(int? Id)
        {
            //Initialize HTML converter 

            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

            // WebKit converter settings

            WebKitConverterSettings webKitSettings = new WebKitConverterSettings();

            //Assign the WebKit binaries path

            webKitSettings.WebKitPath = @"QtBinariesWindows\";

            // Enable table of contents

            webKitSettings.EnableToc = true;

            //Assign the WebKit settings

            htmlConverter.ConverterSettings = webKitSettings;

            //Convert HTML to PDF

            PdfDocument document = htmlConverter.Convert("https://localhost:44339/product");

            //Save the document into stream.

            MemoryStream stream = new MemoryStream();

            document.Save(stream);

            stream.Position = 0;

            //Close the document.

            document.Close(true);

            //Defining the ContentType for pdf file.

            string contentType = "application/pdf";

            //Define the file name.

            string fileName = " Output.pdf";

            //Creates a FileContentResult object by using the file contents, content type, and file name.

            return File(stream, contentType, fileName);
            //return new ViewAsPdf("Details", _Product.GetProduct(Id??1));
        }
        public void Post([FromBody] string value)
        {
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                _Product.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id != null)
            {
                return View(_Product.GetProduct(Id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Product model = _Product.GetProduct(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost([Bind("ID_SP","MOTA_SP","GIA","SOLUONG")] Product product)
        {
            _Product.Update(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Product model = _Product.GetProduct(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Product.Remove(Id);
            return RedirectToAction("index");
        }
    }
}