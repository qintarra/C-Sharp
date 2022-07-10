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

            var query = from employee in employees
                        where employee.Salary > 800
                        orderby employee.LastName, employee.FirstName
                        select employee;

            Console.WriteLine("The highest paid:");
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1} receives ${2}",
                                   item.LastName,
                                   item.FirstName,
                                   item.Salary);
            }
        }
    }
}