using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstInvoice.Models
{
    public class Customer
    {
        #region Attribute
        [Key]
        public int ID_KHACHHANG { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Ten khong duoc vuot qua 30 ki tu")]
        [MaxLength(50)]
        [DisplayName("Tên khách hàng")]
        public string TEN_KHACH_HANG { get; set; }
        [Required]
        [StringLength(50)]
        public string DIA_CHI_KHACH_HANG { get; set; }
        #endregion
    }
}
