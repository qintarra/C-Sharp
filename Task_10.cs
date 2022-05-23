using System;

namespace Task_10

{
    internal class Program
    {
        static void Main(string [] args)
        {
            // Fill an array from keyboard. Entering an array from the console.

            Console.Write("Enter the number of array elements:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int [elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter an array element at index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray output:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nArray output in reverse order:");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}