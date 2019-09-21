using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_empty.Models
{
    public class InvoiceDetails
    {
        public int ID_CTHD { get; set; }
        public int ID_HOADON { get; set; }
        public int ID_SP { get; set; }
        public int SOLUONG { get; set; }
        public double THANHTIEN { get; set; }
    }
}
