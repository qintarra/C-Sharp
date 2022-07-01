using System;
namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //explicit typing
            var b = 10; //implicit typing
            object c = 10;
            dynamic d = 10;
            Console.WriteLine($"{a} {b} {c} {d}");

            a = 20; //20.0 - can't
            b = 30; //30.0 - can't
            c = 40.0; //"another type"      // c + 10 - can't
            d = 50.0; //"is also possible"  // d + 10 - ok
            Console.WriteLine($"{a} {b} {c} {d}");
        }
    }
}