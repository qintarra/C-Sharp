using System;

namespace Notes_05
{
    public static class Program
    {
        static void Main(string[] args)
        {
			//Two-dimensional array
            int[,] array = { { 3, 6, 1},
                           {4, 2, 7 },
                           {9, 0, 8 }};

            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[2, 0]);

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
			
            //It can be skipped if there is no need to output
            Console.WriteLine("Source array");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
			
            //Finding sum in a two-dimensional array (using 'for' cycle)
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    sum += mas[i, j];
                }
            }

            Console.WriteLine($"Sum = {sum}");
			
            //Jaggad arrays
            int[][] mas = new int[3][];
            arr[0] = new int[2]; //allocate memory for the first subarray
            arr[1] = new int[4]; //allocate memory for the second subarray
            arr[2] = new int[3]; //allocate memory for the third subarray
			
            //Entering values from the keyboard
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter {0} row", i + 1);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
			
            //Displayng the jagged array on the screen
            Console.WriteLine("Jagged array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{ arr[i][j]}");
                }
                Console.WriteLine();
            }
			
            //Finding sum in the jagged array through 'for' cycle
            int sum1 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum1 += arr[i][j];
                }
            }
			
            Console.WriteLine($"Sum = {sum1}");
			
            //Finding sum in the jagged array through 'foreach' cycle
            sum1 = 0;
            foreach (int[] y in arr)
            {
                foreach (int x in y)
                {
                    sumq += x;
                }
            }

            Console.WriteLine($"Sum = {sum1} ");
        }
    }
}