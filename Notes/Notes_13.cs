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
    }
}