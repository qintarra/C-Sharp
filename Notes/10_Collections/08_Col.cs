using System;
using System.Collections.Generic;
namespace Collections_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // A guide to the history of the creation of programming languages
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Pascal", 1968);
            dict.Add("C", 1972);
            dict.Add("C++", 1985);
            dict.Add("Java", 1995);
            dict.Add("C#", 2000);
            if (dict.ContainsKey("Pascal"))
            {
                dict.Remove("Pascal");
            }
            // We display information about programming languages
            foreach (var x in dict)
            {
                Console.WriteLine($"The {x.Key} language was created in {x.Value}");
            }
        }
    }
}