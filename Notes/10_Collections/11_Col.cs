using System;
using System.Collections.Specialized;
namespace Collections_11
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection sc = new StringCollection();
            sc.Add("Who");
            sc.Add("wants");
            sc.Add("to");
            sc.Add("live");
            sc.Add("forever");

            for (int i = 0; i < sc.Count; i++)
            {
                Console.WriteLine(sc[i]);
            }
            foreach (var s in sc)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
    }
}