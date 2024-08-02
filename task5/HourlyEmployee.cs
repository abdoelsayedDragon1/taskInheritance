using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class HourlyEmployee:Employee
    {
        public int WorkingHours { get; set; }
        public double HourRate { get; set; }
        public HourlyEmployee(string Name, int Age, string Address, string Nationality, double Salary, string Rank, string Job, int WorkingHours, double HourRate) : base(Name, Age, Address, Nationality, Salary, Rank, Job)
        {
            this.WorkingHours = WorkingHours;
            this.HourRate = HourRate;

        }
        
    }
}
