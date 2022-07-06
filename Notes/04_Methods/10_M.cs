using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method_7
{
    class Program
    {
        //Named parameters
        static int Sum(int x, int y, int z = 3, int s = 4)
        {
            return x + y + z + s;
        }
        static void Main(string [] args)
        {
            int sum1 = Sum(x : 1, y : 2);
            Console.WriteLine(sum1);

            /* In the previous example, when calling methods, the value for parameters
             * passed in the order in which these parameters were declared in the method.
             * But we can break his order by using named parameters
             */
            //Optional parameter z uses a default value
            int sum2 = Sum(y: 2, x: 1, s: 10);
            Console.WriteLine(sum2);
        }
    }
}