using System;
using System.Collections.Generic;
namespace Collections_16
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedset = new SortedSet<int>();
            sortedset.Add(10);
            sortedset.Add(5);
            sortedset.Add(1);
            sortedset.Add(10);
            sortedset.Add(5);
            foreach (int x in sortedset)
            {
                Console.WriteLine(x);
            }
        }
    }
}
