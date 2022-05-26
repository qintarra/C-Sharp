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
			
            //Entering array elements
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
			
            //Loop through an array using for loop
            int sum = 0;
            for (int i = 0; i < m.Length; i++)
            {
                sum += m[i];
            }

            Console.WriteLine($"sum = {sum} ");
			
            //Loop through an array using foreach loop
            sum = 0;
            foreach (int x in m)
            {
                sum += x;
            }

            Console.WriteLine($"sum = {sum} ");
        }
    }
}