using System;

namespace Notes_04
{
    public static class Program
    {
        static void Main(string[] args)
        {
			//5.1
            int[,] arr = { { 3, 6, 1},
                           {4, 2, 7 },
                           {9, 0, 8 }};

            Console.WriteLine(arr[0, 1]);
            Console.WriteLine(arr[2, 0]);

            Console.WriteLine("Enter number of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            int m = int.Parse(Console.ReadLine());

            int[,] mas = new int[n, m];
            Console.WriteLine($"Enter {n*m} items");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
			
            //Can be skipped if no need to output
            Console.WriteLine("Source array");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
			
            //5.2 Find sum in two-dimensional array (using for cycle)
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    sum += mas[i, j];
                }
            }

            Console.WriteLine($"Sum = {sum}");
			
            //5.3 Jaggad arrays
            int[][] mas = new int[3][];
            mas[0] = new int[2]; //allocate memory for the first subarray
            mas[1] = new int[4]; //allocate memory for the second subarray
            mas[2] = new int[3]; //allocate memory for the third subarray

        }
    }
}