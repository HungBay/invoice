using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Models
{
    public class Bill : BaseModel
    {
        public Bill()
        {
            DateOrder = DateTime.Now;
        }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOrder { get; set; }

        [Required]
        public decimal Total { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }

        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
