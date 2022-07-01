using System;
namespace ExtensionMethods_2_5
{
    public static class EnumAndStructExtension
    {
        public static bool IsColdColor(this ConsoleColor color)
        {
            if (color == ConsoleColor.Blue || color == ConsoleColor.Green)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red };
            foreach (var color in colors)
            {
                if (color.IsColdColor())
                {
                    Console.WriteLine($"{color} is a cold color");
                }
                else
                {
                    Console.WriteLine($"{color} is not a cold color");
                }
            }
            for (int i = -2; i < 10; i++)
            {
                if (i.IsPrime())
                {
                    Console.WriteLine($"{i} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{i} is not a prime number");
                }
            }

            Console.WriteLine(193.IsPrime());
            Console.WriteLine(194.IsPrime());
        }
    }
}