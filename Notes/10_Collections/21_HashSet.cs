using System;
using System.Collections.Generic;

namespace LearningHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<string>();

            myHash.Add("hello");
            myHash.Add("hello");

            string[] s = new string[] { "hello" };

            Console.WriteLine(myHash.Count);
            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
