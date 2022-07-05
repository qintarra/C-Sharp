using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method_5
{
    //The advantage of using parameters:
    //you can return several values from the method, not only one
    class Program
    {
        static void GetData(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = 2 * (x + y);
        }

        static void Main(string [] args)
        {
            int a = 12, b = 17;
            GetData(a, b, out int area, out int perimeter);
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }


	    //'In' forbids changing the parameter value in the method body
	    static void Sum(in int x, in int y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }

        static void Main(string [] args)
        {
            int a = 5, b = 7;
            //Sum(in a,in b);
            Sum(a, b);
        }
    }
}