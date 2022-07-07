using System;
namespace Delegate_5
{
    // declare a delegate
    delegate double Fun(double x);
    class Program
    {
        static void Table(Fun y, double x1, double x2, double h)
        {
            double x = x1;
            Console.WriteLine(" ----- x ----- y(x) ---");
            while (x <= x2)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, y(x));
                x += h;
            }
            Console.WriteLine(" ---------------------");
        }
        static double Sqr(double x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Sin function value table ");
            Table(Math.Sin, -2, 2, 1);

            Console.WriteLine(" Cos function value table ");
            Table(Math.Cos, -2, 2, 1);

            Console.WriteLine(" Sqr function value table ");
            Table(Sqr, 0, 5, 1);

            Console.WriteLine(" Anonymous function value table ");
            Table(delegate (double x) { return 2 * x; }, 0, 3, 1);

            Console.WriteLine(" Anonymous function value table ");
            Table(x => 2 * x, 0, 3, 1);
        }
    }
}