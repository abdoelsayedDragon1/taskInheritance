using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class SalariedEmployee:Employee
    {
        public double Bonus { get; set; }
        public double Deductions { get; set; }
        public SalariedEmployee(string Name, int Age, string Address, string Nationality, double Salary, string Rank, string Job, double Bonus, double Deductions): base(Name,Age, Address, Nationality, Salary, Rank, Job)
        {
            this.Bonus = Bonus;
            this.Deductions = Deductions;
        }
    }
}
