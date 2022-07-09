using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_6
{
    class Program
    {
        static void Find(List<string> members, string name,
        Func<string, string, bool> predicate)
        {
            foreach (var member in members)
            {
                if (predicate(member, name))
                {
                    Console.WriteLine(member);
                }
            }
        }
        static void Main(string[] args)
        {
            var words = new List<string> {
            "student",
            "student ticket",
            "stadium",
            "studio",
            "institute",
            "Estudiantes" };

            Console.WriteLine("All lines, that contains 'stud':");
            Find(words, "stud", (x, y) => x.Contains(y));

            Console.WriteLine("All lines, longer than 'student': ");
            Find(words, "student", (x, y) => x.Length > y.Length);

            Console.WriteLine("All lines, starting same as 'student':");
            Find(words, "student", (x, y) => x[0] == y[0]);
        }
    }
}