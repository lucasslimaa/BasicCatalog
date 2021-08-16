using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "The field {0} is required ")]
        [StringLength(200, ErrorMessage = "The field {0}  needs to have between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required ")]
        [StringLength(14, ErrorMessage = "The field {0}  needs to have between {2} and {1} characters", MinimumLength = 11)]
        public string DocumentNumber { get; set; }
        public SupplierType SupplierType { get; set; }
        public Address Address { get; set; }

        [DisplayName("IsActive?")]
        public bool IsActive { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
