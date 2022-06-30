using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Collections_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<int> c = new Collection<int>();
            List<int> l = new List<int>();
            c.Add(5);
            c.Add(20);
            c.Add(10);
            l.Add(5);
            l.Add(20);
            l.Add(10);
            foreach (var x in c)
            {
                Console.WriteLine(x);
            }
            foreach (var x in l)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(c[2]);
            Console.WriteLine(l[2]);
        }
    }
}