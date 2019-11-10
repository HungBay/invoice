using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApi.Models
{
    public class TypeProduct : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
