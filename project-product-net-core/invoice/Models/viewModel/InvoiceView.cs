using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Models.viewModel
{
    public class InvoiceView
    {
        [Key]
        [DisplayName("ID")]
        public int ID_SP { get; set; }
        [DisplayName("Mô tả sản phẩm")]
        public string MOTA_SP { get; set; }
        [DisplayName("Giá")]
        public double GIA { get; set; }

        [DisplayName("Số lượng")]
        public int SOLUONG { get; set; }

        [DisplayName("Mã khách hàng")]
        public int ID_KHACHHANG { get; set; }

        [DisplayName("Địa chỉ KH")]
        public string DIA_CHI_KHACH_HANG { get; set; }

        [DisplayName("Tên KH")]
        public string TEN_KHACH_HANG { get; set; }

        [DisplayName("Mã hóa đơn")]
        public int ID_HOADON { get; set; }

        [DisplayName("Ngày bán")]
        [DataType(DataType.Date)]
        public DateTime NGAYBAN { get; set; }
    }
}
