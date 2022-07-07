using System;
namespace Delegate_3
{
    delegate void Del();
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method 1 executed");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2 executed");
        }
        static void Method3()
        {
            Console.WriteLine("Method 3 executed");
        }
        static void Main(string[] args)
        {
            Del d = Method1;
            d += Method2;
            d += Method3;
            d(); //multicasting
            Console.WriteLine();
            d += Method1;
            d += Method3;
            d();
            Console.WriteLine();
            d -= Method1;
            d();
            Console.WriteLine();
            d -= Method1;
            d();
            // trying to subtract a non-existent method reference does not result in an error
            Console.WriteLine();
            d -= Method1;
            d();
        }
    }
}