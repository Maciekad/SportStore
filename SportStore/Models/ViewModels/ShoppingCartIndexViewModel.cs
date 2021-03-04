using System;
using System.Collections.Generic;
using System.Text;

namespace SportStoreDal.Models.ViewModels
{
    public class ShoppingCartIndexViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
