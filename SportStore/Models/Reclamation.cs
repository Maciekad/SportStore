using SportStoreDal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Reclamation
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer CustomerNavigation { get; set; }
        public int? SalesmanId { get; set; }
        [ForeignKey(nameof(SalesmanId))]
        public Salesman SalesmanNavigation { get; set; }
    }
}
