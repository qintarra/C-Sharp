using System;

namespace Notes_02
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = n / 10 % 10;
            int c = n % 10;
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            int mid = a + b + c - max - min;

            Console.WriteLine(Convert.ToInt32($"{max}{mid}{min}"));
			
            //2.1
            Console.WriteLine("Please, enter a number from 1 to 4");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("You typed 1");
                    break;
                case 2:
                    Console.WriteLine("You typed 2");
                    break;
                case 3:
                    Console.WriteLine("You typed 3");
                    break;
                case 4:
                    Console.WriteLine("You typed 4");
                    break;
                default:
                    Console.WriteLine("You are mistaken");
                    break;
            }
            Console.WriteLine("Continue...");

        }


    }
}