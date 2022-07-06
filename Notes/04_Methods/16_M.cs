using System;
namespace Method_12_3
{
    class Program
    {
        static void Method(int[] arr)	//whithout ref
        {
            arr = new int[] { 10, 20, 30 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
                Console.Write($"{arr[i]} ");

            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Method (arr);

            Console.WriteLine();
            foreach (int x in arr)
                Console.Write($"{x} ");
            Console.WriteLine();
            //20 40 60
            //1 2 3 4 5
        }
    }
}