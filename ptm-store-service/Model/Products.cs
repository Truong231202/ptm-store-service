using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyClass.Model
{
    [Table("Products")]
    public class Products
    {
        [Key] public int ProductId { get; set; }
        [Required] public int CategoryId { get; set; }
        [Required] public string ProductName { get; set; }
        public string ProductSlug { get; set; }
        [Required] public string Title { get; set; }
        public string MainProductImage { get; set; }
        [Required] public decimal Price { get; set; }
        [Required] public decimal SalePrice { get; set; }
        [Required] public string ProductDescription { get; set; }
        [Required] public string ProductTag { get; set; }
        [Required] public string SkuCode { get; set; }

        public Categories Categories { get; set; }
        public ICollection<CartLines> CartLines { get; set; }
    }
}
