using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Models
{
    public class Invoice
    {
        #region Attribute
        [Key]
        [DisplayName("ID")]
        public int ID_HOADON { get; set; }

        [DisplayName("Mã khách hàng")]
        [Required]
        public int ID_KHACHHANG { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Ngày mua hàng")]
        public DateTime NGAYBAN { get; set; }


        public Customer Customers { get; set; }
        #endregion
    }
}
