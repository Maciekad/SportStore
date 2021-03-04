using SportStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportStoreDal.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
