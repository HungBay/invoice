using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Models.viewModel
{
    public class invoiceView
    {
        [Key]
        public int ID_SP { get; set; }
        public string MOTA_SP { get; set; }
        public double GIA { get; set; }
        public int SOLUONG { get; set; }
        public int ID_KHACHHANG { get; set; }
        public string DIA_CHI_KHACH_HANG { get; set; }
        public string TEN_KHACH_HANG { get; set; }
        public int ID_HOADON { get; set; }
        public DateTime NGAYBAN { get; set; }
    }
}
