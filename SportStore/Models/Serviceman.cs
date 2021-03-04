using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Serviceman : Employee
    {
        public int Repairs { get; set; }
        public double RepairRate { get; set; }
        public override double CalculateSalary()
        {
            return Repairs * RepairRate;
        }
    }
}
