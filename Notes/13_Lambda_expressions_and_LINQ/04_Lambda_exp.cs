using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<T, TResult> is a standard delegate encapsulating method with one parameter
            // and returning a value of the type specified by the TResult parameter.
            Func<int, double> f1 = x => x / 2;
            Func<double, double> f2 = x => x / 2;
            Func<double, int> f3 = x => (int)x / 2;
            int n = 9;
            Console.WriteLine("Result 1 = {0}", f1(n));
            Console.WriteLine("Result 2 = {0}", f2(n));
            Console.WriteLine("Result 3 = {0}", f3(n));

            Func<int, int, bool> f = (x, y) => x == y;
            int a = 5, b = 6, c = 5;
            if (f(a, b))
                Console.WriteLine("The numbers are equal");
            else
                Console.WriteLine("The numbers are not equal");

            // Implement a function that determines the maximum of three numbers
            Func<int, int, int, int> max3 = (x, y, z) => Math.Max(Math.Max(x, y), z);
            Console.WriteLine(max3(2, 8, 5));
        }
    }
}