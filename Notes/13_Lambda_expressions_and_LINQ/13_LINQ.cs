using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_4
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating database of employees.
            var employees = new List<Employee>
            {
            new Employee {FirstName = "Andrew", LastName = "Anderson", Salary = 450 },
            new Employee {FirstName = "Jonh", LastName = "Smith", Salary = 900 },
            new Employee {FirstName = "Raul", LastName = "Morientes", Salary = 850 },
            new Employee {FirstName = "Samantha", LastName = "Smith", Salary = 900 }
            };

            var query = employees
                .Where(emp => emp.Salary > 800)
                .OrderBy(emp => emp.LastName)
                .ThenBy(emp => emp.FirstName);


            Console.WriteLine("The highest paid:");
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1} receives ${2}",
                                   item.LastName,
                                   item.FirstName,
                                   item.Salary);
            }

            // Mixed query syntax
            // Sort by last name and display the first name in the list
            string name = (from employee in employees
                           orderby employee.LastName
                           select employee).First().FirstName;
            Console.WriteLine("Name of the first in the list {0}", name);

            // Calculate the number of employees with the letter "n" in their first name
            int number = (from employee in employees
                          where employee.FirstName.Contains('n')
                          select employee).Count();
            Console.WriteLine("Number of names with the letter 'n' = {0}", number);
        }
    }
}