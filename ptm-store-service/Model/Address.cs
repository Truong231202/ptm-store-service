using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Address")]
    public class Address
    {
        [Key] public int AddressId { get; set; }
        [Required] public int CustomerId { get; set; }
        [Required] public string Street { get; set; }
        [Required] public string Ward { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Province { get; set; }
    }
}
