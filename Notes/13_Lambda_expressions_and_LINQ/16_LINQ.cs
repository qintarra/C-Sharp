using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_8
{
    public class EmployeeId
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class EmployeeSalary
    {
        public string Id { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating database of employees.
            var employees = new List<EmployeeId>() 
            {
            new EmployeeId {FirstName = "Andrew", LastName = "Anderson", Id = "111" },
            new EmployeeId {FirstName = "Jonh", LastName = "Smith", Id = "122" },
            new EmployeeId {FirstName = "Raul", LastName = "Morientes", Id = "133" },
            new EmployeeId {FirstName = "Samantha", LastName = "Smith", Id = "124" }
            };

            // Creating a collection of salaries
            var empSalaries = new List<EmployeeSalary>() 
            {
            new EmployeeSalary{ Id = "111",Salary = 450 },
            new EmployeeSalary{ Id = "122",Salary = 900 },
            new EmployeeSalary{ Id = "133",Salary = 850 },
            new EmployeeSalary{ Id = "124",Salary = 900 }
            };

            // Building a query
            var query = from emp in employees
                        join n in empSalaries
                        on emp.Id equals n.Id
                        orderby n.Salary
                        select new
                        {
                            emp.Id,
                            emp.FirstName,
                            emp.LastName,
                            n.Salary
                        };

            foreach (var person in query)
            {
                Console.WriteLine("{0} {1} {2} {3}",
                person.Id,
                person.FirstName,
                person.LastName,
                person.Salary);
            }
        }
    }
}