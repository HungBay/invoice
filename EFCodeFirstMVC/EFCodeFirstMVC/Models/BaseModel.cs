using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVC.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }
        
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }
    }
}
