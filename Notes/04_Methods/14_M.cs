using System;
namespace Method_12_1
{
    class Program
    {
		static void Method(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
                Console.Write($"{arr[i]} ");

            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Method (arr); //Method (ref arr); - result will be the same

            Console.WriteLine();
            foreach (int x in arr)
                Console.Write($"{x} ");
            Console.WriteLine();
        }
	}
}