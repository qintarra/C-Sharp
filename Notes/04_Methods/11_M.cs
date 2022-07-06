using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Method_8
{
    //Using the params keyword you can pass undefined number of parameters
    class Program
    {

        static void Sum(params int [] numbers)
        {
            int result = 0;
            foreach (int x in numbers)
            {
                result += x;
            }
            Console.WriteLine(result);
        }
        static void Main(string [] args)
        {
            Sum(2, 5, 8, 2, 3);
            Sum(5, 9);
            Sum();

            int [] array = { 3, 1, 6, 4 }; 
            Sum(array);
        }
    }
}