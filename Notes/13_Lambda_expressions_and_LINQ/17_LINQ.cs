using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_9
{
    public class EmployeeId
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }
    public class LangSpoken
    {
        public string Nationality { get; set; }
        public string Language { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating database of employees.
            var employees = new List<EmployeeId>() {
            new EmployeeId{ Id = "111",
                            Name = "Carl Sagan" },
            new EmployeeId{ Id = "122",
                            Name = "Isaac Newton" },
            new EmployeeId{ Id = "133",
                            Name = "Alan Turing" },
            new EmployeeId{ Id = "124",
                            Name = "Nikolai Amosov" }
            };

            // Creating database of nationality
            var empNationalities = new List<EmployeeNationality>() {
            new EmployeeNationality{ Id = "111",
                                     Nationality = "American" },
            new EmployeeNationality{ Id = "122",
                                     Nationality = "English" },
            new EmployeeNationality{ Id = "133",
                                     Nationality = "English" },
             new EmployeeNationality{ Id = "124",
                                     Nationality = "Ukrainian" }
            };

            var langSpoken = new List<LangSpoken>() {
            new LangSpoken{ Nationality = "Ukrainian",
                            Language = "Ukrainian" },
            new LangSpoken{ Nationality = "English",
                            Language = "English" },
            new LangSpoken{ Nationality = "American",
                            Language = "English" }
            };

            // Building a query
            var query = from emp in employees
                        join n in empNationalities
                        on emp.Id equals n.Id
                        join l in langSpoken
                        on n.Nationality equals l.Nationality
                        orderby n.Nationality descending
                        select new
                        {
                            emp.Id,
                            emp.Name,
                            n.Nationality,
                            l.Language
                        };
            foreach (var person in query)
            {
                Console.WriteLine("{0}, {1}, \t{2}, {3}",
                                   person.Id,
                                   person.Name,
                                   person.Nationality,
                                   person.Language);
            }
        }
    }
}