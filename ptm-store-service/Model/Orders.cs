using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Orders")]
    public class Orders
    {
        [Key] public int OrderId { get; set; }
        [Required] public int UserID { get; set; }
        [Required] public string AddressId { get; set; }
        [Required] public string PhoneId { get; set; }
        public string Note { get; set; }
        [Required] public decimal OrderQuantity { get; set; }
        [Required] public decimal OrderTotal { get; set; }
        [Required] public DateTime OrderDate { get; set; }
        [Required] public int PaymentMethodId { get; set; }
        [Required] public int ShippingMethodId { get; set; }
    }
}
