using SportStoreDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public abstract class Employee : Person
    {
        public DateTime HireDate { get; set; }
        public DateTime DismissalDate { get; set; }
        public decimal Salary { get; set; }
        public abstract double CalculateSalary();

    }
}
