using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_16_3
{
    class StudentNames : IEnumerable<string>
    {
        private string[] listStudents =
        {
             "Steve Jobs",
             "Larry Page",
             "Bill Gates",
             "Sergey Brinn",
             "Mark Zuckerberg",
        };

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string name in listStudents)
            {
                yield return name;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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