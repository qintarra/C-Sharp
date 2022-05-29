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
        }
    }
}