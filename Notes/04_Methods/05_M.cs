using System;
namespace Method_2
{
    // Passing parameters by reference and the ref modifier
    class Program
    {
        //Method definition
        static void Sum(ref int x, int y)
        {
            x += y;
            Console.WriteLine($"The value in the method {x}");
        }

        static void Main(string [] args)
        {
            //The argument passed to the ref parameter
            //Must be initialized first
            int x = 10;
            int y = 15;
            Sum(ref x, y); //method call
            Console.WriteLine($"The value after method {x}");
        }
    }
}