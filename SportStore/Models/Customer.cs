using SportStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreDal.Models
{
    public class Customer : Person
    {
        [InverseProperty(nameof(Order.CustomerNavigation))]
        public List<Order> Orders { get; set; } = new List<Order>();

        [InverseProperty(nameof(Opinion.CustomerNavigation))]
        public List<Opinion> Opinions { get; set; } = new List<Opinion>();

        [InverseProperty(nameof(Reclamation.CustomerNavigation))]
        public List<Reclamation> Reclamations { get; set; } = new List<Reclamation>();

    }
}
