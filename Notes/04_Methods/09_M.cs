using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method_6
{
   /* C# allows an optional parameters.
    * For such parameters you must declare a default value.
    * Also keep in min thet after an optional parameters
    * all subsequent parameters must also be optional
    */
	class Program
    {
        static int Sum(int x, int y, int z = 3, int s = 4)
        {
            return x + y + z + s;
        }
        static void Main(string [] args)
        {
            //Since the last two parameters are declared optional,
            //then we can omit one or both of them
            int sum1 = Sum(1, 2);
            Console.WriteLine(sum1);
            int sum2 = Sum(1, 2, 10);
            Console.WriteLine(sum2);
            int sum3 = Sum(10, 20, 30, 40);
            Console.WriteLine(sum3);
        }
    }
}