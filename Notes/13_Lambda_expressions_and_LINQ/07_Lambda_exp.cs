using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_7
{
    static class MyExtensions
    {
        public static IEnumerable EvenItems(this IEnumerable x)
        {
            foreach (int y in x)
            {
                if (y % 2 == 0)
                {
                    yield return y;
                }
            }
        }
        public static IEnumerable FindItems(this IEnumerable x, Predicate<int> f)
        {
            foreach (int y in x)
            {
                if (f(y))
                {
                    yield return y;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 3, 6, 2, 7, 8, 5, 4 };
            IEnumerable data = lst.EvenItems();
            foreach (var t in data)
                Console.Write($"{t} ");

            Console.WriteLine();
            var data1 = lst.FindItems(x => x % 2 == 0);
            foreach (var t in data1)
                Console.Write($"{t} ");

            Console.WriteLine();
            var data2 = lst.FindItems(x => x % 2 != 0);
            foreach (var t in data2)
                Console.Write($"{t} ");

            Console.WriteLine();
            var data3 = lst.FindItems(x => x > 3);
            foreach (var t in data3)
                Console.Write($"{t} ");

            Console.WriteLine();
        }
    }
}