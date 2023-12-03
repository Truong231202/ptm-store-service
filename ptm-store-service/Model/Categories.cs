using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key] public int CategoryId { get; set; }
        [Required] public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
        public int? ParentId { get; set; }
        [Required] public string CategoryDescription { get; set; }
        [Required] public string CategoryTag { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}