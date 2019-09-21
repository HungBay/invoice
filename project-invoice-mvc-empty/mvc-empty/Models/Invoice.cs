using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Models
{
    public class Invoice
    {
        public int ID_HOADON { get; set; }
        public int ID_KHACHHANG { get; set; }
        public DateTime NGAYBAN { get; set; }
    }
}
