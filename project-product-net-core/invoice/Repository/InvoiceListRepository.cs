using invoice.Models;
using invoice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invoice.Models.viewModel;

namespace invoice.Repository
{
    public class InvoiceListRepository : IInvoiceList
    {
        private DB_Context db;

        public InvoiceListRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<invoiceView> ListALL
        {
            get
            {   var model = (from Customer in db.Customers
                join Invoice in db.Invoices on Customer.ID_KHACHHANG equals Invoice.ID_KHACHHANG
                join Invoice_details in db.Invoice_details on Invoice.ID_HOADON equals Invoice_details.ID_HOADON
                join Product in db.Products on Invoice_details.ID_SP equals Product.ID_SP
                select new invoiceView
                {
                    ID_SP = Product.ID_SP,
                    MOTA_SP = Product.MOTA_SP,
                    GIA = Product.GIA,
                    SOLUONG = Product.SOLUONG,
                    ID_KHACHHANG = Customer.ID_KHACHHANG,
                    DIA_CHI_KHACH_HANG = Customer.DIA_CHI_KHACH_HANG,
                    TEN_KHACH_HANG = Customer.TEN_KHACH_HANG,
                    ID_HOADON = Invoice.ID_HOADON,
                    NGAYBAN = Invoice.NGAYBAN,
                    
                }).Distinct().ToList();
                return model;
            }
        }


        public invoiceView ListInvoice(int? Id)
        {
            var model = (from Customer in db.Customers
                         join Invoice in db.Invoices on Customer.ID_KHACHHANG equals Invoice.ID_KHACHHANG
                         join Invoice_details in db.Invoice_details on Invoice.ID_HOADON equals Invoice_details.ID_HOADON
                         join Product in db.Products on Invoice_details.ID_SP equals Product.ID_SP

                         where Customer.ID_KHACHHANG == Id
                         select new invoiceView
                         {
                             ID_SP = Product.ID_SP,
                             MOTA_SP = Product.MOTA_SP,
                             GIA = Product.GIA,
                             SOLUONG = Product.SOLUONG,
                             ID_KHACHHANG = Customer.ID_KHACHHANG,
                             DIA_CHI_KHACH_HANG = Customer.DIA_CHI_KHACH_HANG,
                             TEN_KHACH_HANG = Customer.TEN_KHACH_HANG,
                             ID_HOADON = Invoice.ID_HOADON,
                             NGAYBAN = Invoice.NGAYBAN,
                         }).SingleOrDefault();
            return model;
        }


    }
}
