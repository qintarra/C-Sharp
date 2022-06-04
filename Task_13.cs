using System;

namespace Task_13
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Filling a two-dimensional array with random numbers
            int[,] myArray = new int[10, 6];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);
                }
            }
			
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j] + "\t");
                }
                Console.WriteLine();
            }
			
            //Filling a two-dimensional array from the keyboard
            int[,] array = new int[2, 3];

            Console.WriteLine("Enter an array elements:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}