using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApi.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            status = Status.Active;
        }

        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }

        public Status status { get; set; }
    }
}
