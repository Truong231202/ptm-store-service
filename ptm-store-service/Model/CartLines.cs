using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyClass.Model
{
    [Table("CartLines")]
    public class CartLines
    {
        [Key] public int CartLineId { get; set; }
        [Required] public int CartId { get; set; }
        [Required] public int ProductId { get; set; }
        [Required] public decimal Quantity { get; set; }
        [Required] public decimal TotalPrice { get; set; }

        public Products Products { get; set; }
        public Carts Carts { get; set; }
    }
}