using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Models
{
    public class Invoice_detail
    {
        #region Attribute
        [Key]
        public int ID_CTHD { get; set; }
        [DisplayName("Số hóa đơn")]
        [Required]
        public int ID_HOADON { get; set; }
        [DisplayName("Mã sản phẩm")]
        [Required]
        public int ID_SP { get; set; }
        [DisplayName("Số lượng sản phẩm")]
        [Required]
        public int SOLUONG { get; set; }
        [Required]
        public double THANHTIEN { get; set; }

        public Invoice Invoices { get; set; }
        public Product Products { get; set; }
        #endregion
    }
}
