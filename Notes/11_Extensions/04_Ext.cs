using System;
using System.Collections.Generic;
using System.Linq;
namespace ExtensionMethods_3
{
    static class MyExtensions
    {
        public static int SumEven(this List<int> x)
        {
            int sum = 0;
            foreach (int y in x)
                if (y % 2 == 0) sum += y;
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(4);
            lst.Add(5);
            lst.Add(3);
            lst.Add(2);
            Console.WriteLine("The sum of the list items is {0}", lst.Sum());
            Console.WriteLine("The sum of even elements is {0}", lst.SumEven());

            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("The sum of the array elements is {0}", mas.Sum());
            //Console.WriteLine("The sum of the even elements of the array is {0}", mas.SumEven());
        }
    }
}