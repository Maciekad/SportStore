using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Models
{
    public class Salesman : Employee
    {
        public double HourRate { get; set; }
        public double Hours { get; set; }

        [InverseProperty(nameof(Reclamation.SalesmanNavigation))]
        public List<Reclamation> Reclamations { get; set; }

        public override double CalculateSalary()
        {
            return Hours * HourRate;
        }

        
    }
}
