using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyClass.Model
{
    [Table("Carts")]
    public class Carts
    {
        [Key] public int CartId { get; set; }
        [Required] public int CustomerId { get; set; }

        public ICollection<CartLines> CartLines { get; set; }
    }
}