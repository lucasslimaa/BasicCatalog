using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "The field {0} is required ")]
        [StringLength(200,ErrorMessage = "The field {0}  needs to have between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required ")]
        [StringLength(1000, ErrorMessage = "The field {0}  needs to have between {2} and {1} characters", MinimumLength = 2)]
        public string description { get; set; }

        [Required(ErrorMessage = "The field {0} is required ")]
        public string Image { get; set; }

        [Required(ErrorMessage = "The field {0} is required ")]
        public decimal Value { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsActive { get; set; }
        public Supplier Supplier { get; set; }
    }
}
