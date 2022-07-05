using System;
namespace Method_1
{
    class Program
    {
        static void Sum1(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        static int Sum2(int x, int y)
        {
            return x + y;
        }

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Sum1(a, b);

            //int c = Sum2(a, b);
            Console.WriteLine(Sum2(a,b));          
        }
    }
}