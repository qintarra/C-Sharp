using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_3
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>() {
            new Employee {FirstName = "Andrew", LastName = "Anderson"},
            new Employee {FirstName = "Jonh", LastName = "Smith"},
            new Employee {FirstName = "Raul", LastName = "Morientes"},
            new Employee {FirstName = "Samantha", LastName = "Smith"}
 };
            var query = from emp in employees
                        let fullName = emp.LastName + " " + emp.FirstName
                        orderby fullName
                        select fullName;
            Console.WriteLine("Output in alphabetical order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var query2 = employees.Select(emp => emp.FirstName[0] + "." + emp.LastName);
            Console.WriteLine("Output last name and initials");
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }

            var query3 = employees.Where(emp => emp.FirstName.First().Equals(emp.LastName.First()));
            Console.WriteLine("First name and last name starts with the same letter");
            foreach (var item in query3)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}