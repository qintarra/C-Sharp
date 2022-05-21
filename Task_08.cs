using System;

namespace Task08

{
    // Sum and amount of even and odd numbers in a range
	
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumberSum = 0;
            int evenNumberSum = 0;

            Console.WriteLine("Enter the first number of range");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number of range");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumberSum += currentValue;
                    evenNumbersCount++;
                }
                else
                {
                    oddNumberSum += currentValue;
                    oddNumbersCount++;
                }
                currentValue++;
            }

            Console.WriteLine("Odd numbers amount: " + oddNumbersCount);
            Console.WriteLine("Even numbers amount: " + evenNumbersCount);
            Console.WriteLine("Odd numbers sum: " + oddNumberSum);
            Console.WriteLine("Even numbers sum: " + evenNumberSum);
            Console.ReadLine();
        }
    }
}