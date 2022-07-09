using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lambda_expression_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isPositive = x => x > 0;
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));

            Predicate<bool> negation = x => !x;
            Console.WriteLine(negation(true));

            Predicate<char> isDigit = x => x >= 48 && x <= 57;
            Console.WriteLine(isDigit('9'));
            Console.WriteLine(isDigit(':'));
        }
    }
}
