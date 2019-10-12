using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Models
{
    public class TypeProduct : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        //image

        public ICollection<Product> Products { get; set; }
    }
}
