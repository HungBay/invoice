﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApi.Models
{
    public class Product : BaseModel
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }


        [Required]
        public decimal UnitPrice { get; set; }


        public decimal PromotionPrice { get; set; }

        public string Image { get; set; }

        [Required]
        public string Unit { get; set; }
        public int New { get; set; }

        [ForeignKey("TypeProductId")]
        public Guid TypeProductId { get; set; }
        public TypeProduct TypeProduct { get; set; }
    }
}
