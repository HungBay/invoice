using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVC.Models
{
    public class Product : BaseModel
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public byte [] Images { get; set; }

        public ICollection<BillDetail> BillDetail { get; set; }
    }
}
