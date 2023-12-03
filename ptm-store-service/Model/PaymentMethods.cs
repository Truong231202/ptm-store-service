using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Payment Methods")]
    public class PaymentMethods
    {
        [Key] public int PaymentMethodId { get; set; }
        [Required] public int CustomerId { get; set; }
        [Required] public string Cardnumber { get; set; }
        [Required] public string NameOnCard { get; set; }
        [Required] public DateTime ExpirationDate { get; set; }
    }
}
