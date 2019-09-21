using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Models
{
    public class Product
    {
        #region Attribute
        [Key]
        [DisplayName("ID")]
        public int ID_SP { get; set; }

        [DisplayName("Mô tả")]
        [Required(ErrorMessage ="Yêu cầu nhập mô tả sản phẩm")]
        public string MOTA_SP { get; set; }

        [DisplayName("Giá sản phẩm")]
        [Required(ErrorMessage ="Nhập giá sản phẩm")]
        public double GIA { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Nhập số lượng sản phẩm")]
        public int SOLUONG { get; set; }
        #endregion
    }
}
