using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyClass.Model
{
    [Table("Customers")]
    public class Customers
    {
        [Key] public int CustomerId { get; set; }
        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Fullname { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Role { get; set; } //Customer
        [Required] public int PhoneId { get; set; }
        [Required] public int AddressId { get; set; }
    }
}