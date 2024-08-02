using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Student: Person
    {
        public string StudyLevel { get; set; }
        public string Specialization { get; set; }
        public double GPA { get; set; }
        public Student(string Name, int Age, string Address, string Nationality, string StudyLevel, string Specializaton, double GPA) : base (Name, Age, Address, Nationality) 
        { 
            this.StudyLevel = StudyLevel;
            this.Specialization = Specializaton;
            this. GPA = GPA;
        }
    }
}
