﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfPastries.Models.viewModel
{
    public class BillDetailView : BaseModel
    {
        [Key]
        public Guid BillId { get; set; }

        [Required]
        [StringLength(50)]
        public string NameCustomer { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }


    }
}
