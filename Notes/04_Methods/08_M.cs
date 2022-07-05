using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method_5_4
{
    class Program
    {
		static void Sum(int a, in int b, ref int c, out int d)
        {
            Console.WriteLine($"The sum before change is {a + b + c}");

            // 'out' parameter must be assigned a value to the variable
            d = a + b + c;

            // 'ref' parameter can be changed and these changes are saved
            c = 100;

            // 'in' parameter can't be changed
            //b = 200;

            // 'value' parameter can be changed, but changes are not saved
            a = 300;

            Console.WriteLine($"The sum after change is {a + b + c}");
        }

        static void Main(string [] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;

            Sum(x, in y, ref z, out int s);

            Console.WriteLine($"The value of the first parameter {x}");
            Console.WriteLine($"The value of the second parameter {y}");
            Console.WriteLine($"The value of the third parameter {z}");
            Console.WriteLine($"The value of the fourth parameter {s}");
        }
    }
}