using System;
using System.Collections;
namespace ExtensionMethods_5
{
    // Extension Methods with Arguments
    public static class EnumerableExtensions
    {
        // Getting every n-th element
        public static IEnumerable GetEveryNth(this IEnumerable source, int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n));
            int index = 1;
            foreach (var element in source)
            {
                if (index % n == 0)
                    yield return element;
                index++;
            }
        }
        // Getting every second item
        public static IEnumerable GetEverySecond(this IEnumerable source)
        {
            return source.GetEveryNth(2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            foreach (var x in a)
                Console.Write(x + " "); // 1 2 3 4 5 6
            Console.WriteLine();

            // We get every third element
            var t = a.GetEveryNth(3);
            foreach (var x in t)
                Console.Write(x + " "); // 3 6
            Console.WriteLine();

            // We get every second element
            foreach (var x in a.GetEverySecond())
                Console.Write(x + " "); // 2 4 6
            Console.WriteLine();
        }
    }
}