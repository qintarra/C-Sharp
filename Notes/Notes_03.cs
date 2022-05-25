using System;

namespace Notes_03
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int max;

            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            Console.WriteLine($"Max = {max}");

            max = x > y ? x : y; //solution with ternary operator

            Console.WriteLine($"Max = {max}");

            Console.WriteLine($"max = {(x > y ? x : y)}"); //another solution

           


        }

    }
}