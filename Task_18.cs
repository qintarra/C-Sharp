using System;

namespace Task_18
{
    internal class Program
    {
        //Write a method that displays a string
        static void PrintString (string symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.WriteLine(symbol);
            }
        }

        static void Main(string [] args)
        {
            Console.WriteLine("Enter a symbols:");
            string symbol = Console.ReadLine();

            Console.WriteLine("Enter the number of symbols:");
            uint symbolCount = uint.Parse(Console.ReadLine());

            PrintString(symbol, symbolCount);
        }
		
    }
}