using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVC.Models
{
    public class BillDetail : BaseModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }


        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
