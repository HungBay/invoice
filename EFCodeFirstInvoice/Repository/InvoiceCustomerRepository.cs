using EFCodeFirstInvoice.Models.viewModel;
using EFCodeFirstInvoice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Repository
{
    public class InvoiceCustomerRepository : IInvoiceCustomer
    {
        private InvoiceDbContext db;
        public InvoiceCustomerRepository(InvoiceDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<InvoiceView> GetInvoiceCustomers
        {
            get
            {
                var model = (from Customer in db.Customers
                             join Invoice in db.Invoices on Customer.ID_KHACHHANG equals Invoice.ID_KHACHHANG
                             join Invoice_details in db.Invoice_details on Invoice.ID_HOADON equals Invoice_details.ID_HOADON
                             join Product in db.Products on Invoice_details.ID_SP equals Product.ID_SP
                             select new InvoiceView
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

        public IEnumerable<InvoiceView> InvoiceCustomer(int? Id)
        {
            var model = (from Customer in db.Customers
                         join Invoice in db.Invoices on Customer.ID_KHACHHANG equals Invoice.ID_KHACHHANG
                         join Invoice_details in db.Invoice_details on Invoice.ID_HOADON equals Invoice_details.ID_HOADON
                         join Product in db.Products on Invoice_details.ID_SP equals Product.ID_SP

                         where Customer.ID_KHACHHANG == Id
                         select new InvoiceView
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
                         }).ToList();
            return model;
        }
    }
}
