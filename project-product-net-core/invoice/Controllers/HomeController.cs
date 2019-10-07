using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using invoice.Models;
using invoice.Services;
using invoice.Models.viewModel;
using invoice.Repository;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.IO;
using Rotativa.AspNetCore;
using Syncfusion.Pdf.HtmlToPdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;

namespace invoice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInvoiceList _InvoiceList;

        public HomeController(IInvoiceList _IInvoiceList)
        {
            _InvoiceList = _IInvoiceList;
            
        }

        public IActionResult Index()
        {
            return View(_InvoiceList.ListALL);
        }

        public IActionResult Details(int? Id)
        {
            return View(_InvoiceList.ListInvoice(Id??1));
        }

        public IActionResult ExportToPDF(int? Id)
        {
            //Initialize HTML to PDF converter 
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

            WebKitConverterSettings settings = new WebKitConverterSettings();

            //HTML string and Base URL 
            string htmlText = "<html><body><img src=\"syncfusion_logo.gif\" alt=\"Syncfusion_logo\" width=\"200\" height=\"70\"><p> Hello World</p></body></html>";

            string baseUrl = @"E:/Anglar 5/";

            //Set WebKit path
            settings.WebKitPath = @"QtBinariesWindows\";

            //Assign WebKit settings to HTML converter
            htmlConverter.ConverterSettings = settings;

            //Convert HTML string to PDF
            PdfDocument document = htmlConverter.Convert(htmlText, baseUrl);

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
            //return new ViewAsPdf("Details", _InvoiceList.ListInvoice(Id));
        }

        public void Post([FromBody] string value)
        {
        }

    }
}
