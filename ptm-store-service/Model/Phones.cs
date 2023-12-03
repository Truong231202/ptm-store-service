using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Phones")]
    public class Phones
    {
        [Key] public int PhoneId { get; set; }
        [Required] public int CustomerId { get; set; }
        [Required] public string PhoneNumber { get; set; }
    }
}
