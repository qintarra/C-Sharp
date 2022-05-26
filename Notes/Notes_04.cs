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
			
            //Finding minimum and maximum values
            int min = m[0];
            int nmin = 0;
            int max = m[0];
            int nmax = 0;

            for (int i = 1; i < 5; i++)
            {
                if (min > m[i])
                {
                    min = m[i];
                    nmin = i;
                }
                if (max < m[i])
                {
                    max = m[i];
                    nmax = i;
                }
            }

            Console.WriteLine($"Minimum = {min} position = {nmin}");
            Console.WriteLine($"Maximum = {max} position = {nmax}");
        }
    }
}