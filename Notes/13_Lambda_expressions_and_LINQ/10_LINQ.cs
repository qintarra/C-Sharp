using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 8, 3, 4 };
            var t = from x in numbers select x;
            foreach (var a in t)
                Console.Write("{0} ", a);
            Console.WriteLine();

            int[] numbers2 = { 1, 2, 3, 4 };
            var query = from x in numbers2
                        where x % 2 == 0
                        select x * 2;
            foreach (var item in query)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

        }
    }
}