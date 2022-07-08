using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_1
{
    delegate double MyDelegate(double x);
    /* Lambda expressions have the following syntax:
     * To the left of the lambda operator => a list of parameters is defined,
     * and to the right an expression block using these parameters:
     * (input-parameters) => expression.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // f(x) = x + 1
            MyDelegate md1 = x => x + 1;
            Console.WriteLine(md1(2));

            // f(x) = x^2 + 2*x + 4
            md1 = x => x * x + 2 * x + 4;
            Console.WriteLine(md1(2));

            // Calculate the square root
            md1 = y => Math.Sqrt(y);
            Console.WriteLine(md1(25));

            // s = 1/2 + 1/3 + ... +1/n
            md1 = n =>
            {
                double s = 0;
                for (int i = 2; i <= n; i++) s += 1.0 / i;
                return s;
            };
            Console.WriteLine(md1(10));
        }
    }
}