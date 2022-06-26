using System;
using System.Collections;
namespace OOP_16_1
{
    class StudentNames : IEnumerable // the simplest iterator
    {
        public IEnumerator GetEnumerator()
        {
            // The yield return operator is used to return
            // each element one by one
            yield return "Steve Jobs";
            yield return "Larry Page";
            yield return "Bill Gates";
            yield return "Sergey Brinn";
            yield return "Mark Zuckerberg";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentNames names = new StudentNames();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}