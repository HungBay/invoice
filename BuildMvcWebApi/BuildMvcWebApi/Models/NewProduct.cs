using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildMvcWebApi.Models
{
    public class NewProduct : BaseModel
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Context { get; set; }

        public string Image { get; set; }
    }
}
