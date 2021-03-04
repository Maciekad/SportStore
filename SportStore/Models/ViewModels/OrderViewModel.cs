using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SportStore.Models.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public IEnumerable<OrderLineViewModel> Lines { get; set; }

        [Required(ErrorMessage = "Proszę podać imię i nazwisko.")]
        public string FullName { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę miasta.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę województwa")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę kraju.")]
        public string Country { get; set; }
        public decimal TotalValue { get; set; }
    }
}
