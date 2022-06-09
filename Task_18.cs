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
		
		//Write a method to find the indexes of array elements (typeof int)
        //The method must return the index of the first found element.
        static int IndexOf (int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == value)
                {
                    return i;
                }
            }

            return -1;//if an element doesn't exist
        }

        static int [] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void Main(string [] args)
        {
            int[] myArray = GetRandomArray(10, -10, 20);

            int result = IndexOf(myArray, 5);

            Console.WriteLine(result);
        }
    }
}