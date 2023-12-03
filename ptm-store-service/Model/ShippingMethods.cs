using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Shipping Methods")]
    public class ShippingMethods
    {
        [Key] public int ShippingMethodId { get; set; }
        [Required] public string ShippingMethodName { get; set; }
        [Required] public decimal ShippingPrice { get; set; }
    }
}
