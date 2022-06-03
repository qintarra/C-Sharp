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
        }
    }
}