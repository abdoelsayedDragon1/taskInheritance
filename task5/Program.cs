namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Abdo", 30, "Giza", "egypt");
            Student student = new Student("Noah",20, "Giza", "egypt", "first", "Computer Science", 3.8);
            Employee employee = new Employee("Marwan", 40, "Nasr City", "Egyptian", 60000, "Manager", "Engineering");
            SalariedEmployee salariedEmployee = new SalariedEmployee("ossama", 35, "6 Octopetr ", "Egyptian", 80000, "Senior Manager", "Marketing", 5000, 2000);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("said", 25, "Giza", "Egyptian",6, "Technician", "Maintenance", 40, 25);

            
            Console.WriteLine($"Person: {person.Name}, {person.Age}, {person.Address}, {person.Nationality}");
            Console.WriteLine($"Student: {student.Name}, {student.Age}, {student.Address}, {student.Nationality}, {student.StudyLevel}, {student.Specialization}, {student.GPA}");
            Console.WriteLine($"Employee: {employee.Name}, {employee.Age}, {employee.Address}, {employee.Nationality}, {employee.Salary}, {employee.Rank}, {employee.Job}");
            Console.WriteLine($"SalariedEmployee: {salariedEmployee.Name}, {salariedEmployee.Age}, {salariedEmployee.Address}, {salariedEmployee.Nationality}, {salariedEmployee.Salary}, {salariedEmployee.Rank}, {salariedEmployee.Job}, {salariedEmployee.Bonus}, {salariedEmployee.Deductions}");
            Console.WriteLine($"HourlyEmployee: {hourlyEmployee.Name}, {hourlyEmployee.Age}, {hourlyEmployee.Address}, {hourlyEmployee.Nationality}, {hourlyEmployee.WorkingHours}, {hourlyEmployee.HourRate}");
        
    }
    }
}
