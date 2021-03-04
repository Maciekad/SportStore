using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SportStoreDal.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal UnitCost { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category CategoryNavigation { get; set; }

        [NotMapped]
        public string CategoryName => CategoryNavigation?.CategoryName;


    }
}
