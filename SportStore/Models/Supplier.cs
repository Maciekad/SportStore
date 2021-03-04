using SportStoreDal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }

        [InverseProperty(nameof(Order.SupplierNavigation))]
        public List<Order> Orders { get; set; } = new List<Order>();


    }
}
