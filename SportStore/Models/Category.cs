using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SportStoreDal.Models
{
    [Table("Categories", Schema="SportStore")]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [DataType(DataType.Text), MaxLength(50)]
        public string CategoryName { get; set; }

        [InverseProperty(nameof(Product.CategoryNavigation))]
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
