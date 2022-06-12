using System;

namespace Notes_13.cs
{
    enum StaffPosition
    {
        Junior,
        Middle,
        Senior,
        Lead
    }
    internal class Program
    {
        static void Welcome(string name, StaffPosition position)
        {
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"Welcome to the position {position} at Amazon!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Welcome("Jeronimo", StaffPosition.Junior);
            Welcome("Aribeth", StaffPosition.Lead);
        }
		
		//13.2
		
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

            Method (arr); //Method (ref arr); - result will be the same, because... Remember! About reference type of an arrays

            Console.WriteLine();
            foreach (int x in arr)
                Console.Write($"{x} ");
            Console.WriteLine();
        }
		
        //13.3
		
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

        }
        //20 40 60
        //20 40 60
    }
}