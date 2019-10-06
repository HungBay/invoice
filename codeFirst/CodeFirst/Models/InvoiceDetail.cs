using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class InvoiceDetail
    {
        public int Id{ get; set; }
        public int Quanity { get; set; }

        

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        
    }
}
