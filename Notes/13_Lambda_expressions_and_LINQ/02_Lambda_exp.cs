using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_2
{
    // How to get the sum of the squares of two integers?
    // Let's declare a delegate that takes two arguments of type int and returns an int
    delegate int MathDelegate(int x, int y);
    class Program
    {
        static int SummaSqr(int x, int y)
        {
            return (x * x) + (y * y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("5*5 + 3*3 = {0}", SummaSqr(5, 3));

            MathDelegate md;
            // Using an anonymous method
            // We pass to the delegate a block of code, which is an anonymous method
            md = delegate (int x, int y) { return (x * x) + (y * y); };
            Console.WriteLine("5*5 + 3*3 = {0}", md(5, 3));

            //Using lambda expression instead of an anonymous method
            md = (x, y) => x * x + y * y;
            Console.WriteLine("5*5 + 3*3 = {0}", md(5, 3));
        }
    }
}