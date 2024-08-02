using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Employee:Person
    {
        public double Salary { get; set; }
        public string Rank { get; set; }
        public string Job { get; set; }
        public Employee(string Name, int Age, string Address, string Nationality, double Salary, string Rank, string Job): base(Name, Age, Address,Nationality)
        {
            this.Salary = Salary;
            this.Rank = Rank;
            this.Job = Job;
        }
    }
}
