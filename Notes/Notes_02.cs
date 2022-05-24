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

        }


    }
}