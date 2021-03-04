using Microsoft.AspNetCore.Mvc.ModelBinding;
using SportStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SportStoreDal.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [InverseProperty(nameof(OrderDetail.OrderNavigation))]
        public List<OrderDetail> Details { get; set; }
        [Required(ErrorMessage = "Proszę podać imię i nazwisko.")]
        public DateTime OrderDate { get; set; }
        public DateTime ShipmentDate { get; set; }
       
        [Required(ErrorMessage = "Proszę podać nazwę miasta.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę województwa")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę kraju.")]
        public string Country { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer CustomerNavigation { get; set; }
        public int? SupplierId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public Supplier SupplierNavigation { get; set; }



    }
}
