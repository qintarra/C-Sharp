using System;
namespace Method_12_2
{
    class Program
    {
        static void Method(ref int[] arr) //whith ref
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

            Method (ref arr);

            Console.WriteLine();
            foreach (int x in arr)
                Console.Write($"{x} ");
            Console.WriteLine();
            //20 40 60
            //20 40 60
        }
    }
}