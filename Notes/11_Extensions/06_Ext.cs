using System;
using System.Collections.Generic;
using System.Collections;
namespace ExtensionMethod_6
{
    static class AnnoyingExtensions
    {
        // The PrintData () method can be applied by any class or structure,
        // which implements the IEnumerable interface.
        public static void PrintData(this IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Array class implements IEnumerable
            string[] data =
            {
                "There's", "no", "time", "for", "us", "There's", "no", "place", "for", "us"
            };
            data.PrintData();
            Console.WriteLine();

            // Class List<T> implements IEnumerable
            List<int> myInts = new List<int>() { 10, 15, 20 };
            myInts.PrintData();
            Console.WriteLine();

            // Class ArrayList implements IEnumerable
            ArrayList list = new ArrayList() { 7, 'x', 4.5 };
            list.PrintData();
        }
    }
}