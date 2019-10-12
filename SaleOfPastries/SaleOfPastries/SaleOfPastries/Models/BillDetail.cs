using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Models
{
    public class BillDetail : BaseModel
    {
        [Required]
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }


        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("BillId")]
        public Guid BillId { get; set; }
        public Bill Bill { get; set; }
    }
}
