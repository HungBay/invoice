using SaleOfPastries.Models;
using SaleOfPastries.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.viewModels
{
    public class TypeProductCreateViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public IFormFile ImagePath { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
