using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_9
{
    // Chaining lambda expressions
    class Program
    {
        static Func<T, S> Chain<T, R, S>(Func<T, R> func1, Func<R, S> func2)
        {
            return x => func2(func1(x));
        }
        static void Main(string[] args)
        {
            Func<int, double> chain1 = Chain<int, int, double>(x => x * 3, x => x + 3.5);
            Console.WriteLine(chain1(2));

            Func<string, bool> chain2 = Chain<string, char, bool>(str => str[0], ch => char.IsDigit(ch));

            Console.WriteLine(chain2("x1"));
            Console.WriteLine(chain2("1x"));
        }
    }
}