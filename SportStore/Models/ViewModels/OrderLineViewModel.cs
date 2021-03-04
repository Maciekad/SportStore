using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models.ViewModels
{
    public class OrderLineViewModel
    {
        public int Quantity { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
