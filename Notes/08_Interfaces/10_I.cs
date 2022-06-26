using System;
using System.Collections;
namespace OOP_16_2
{
    class StudentNames : IEnumerable
    {
        private string[] listStudents =
        {
             "Steve Jobs",
             "Larry Page",
             "Bill Gates",
             "Sergey Brinn",
             "Mark Zuckerberg",
        };
        public IEnumerator GetEnumerator()
        {
            return listStudents.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentNames names = new StudentNames();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}