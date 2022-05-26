using System;

namespace Notes_04
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Initialization with a list of values
            int[] m = { 2, 1, 0, 3, 9 };

            Console.WriteLine($"Element as index 0 = {m[0]}");
			
            //Displaying array elements to string separated by space
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{m[i]} ");
            }

            Console.WriteLine();
        }
    }
}