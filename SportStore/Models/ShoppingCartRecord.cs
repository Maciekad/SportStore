using SportStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SportStoreDal.Models
{
    public class ShoppingCartRecord
    {
        public int Quantity { get; set; }

        public ProductViewModel Product { get; set; }
    }
}
