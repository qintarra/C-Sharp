using System;

namespace Notes_03
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int max;

            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            Console.WriteLine($"Max = {max}");

            max = x > y ? x : y; //solution with ternary operator
            Console.WriteLine($"Max = {max}");

            Console.WriteLine($"max = {(x > y ? x : y)}"); //another solution


            int z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z)
                {
                    max = x;
                }
                else
                {
                    max = z;
                }
            }
            else
            {
                if (y > z)
                {
                    max = y;
                }
                else
                {
                    max = z;
                }
            }

            Console.WriteLine(max);

            max = x > y ? x > z ? x : z : y > z ? y : z; //using ternary operator
            Console.WriteLine(max);
			
			
            //3.1
            int a = 1;
            while (a < 11)
            {
                Console.WriteLine(x);
                a = a + 1; //a++
            }
			
            //3.2
            int b = 1;
            do
            {
                Console.WriteLine(x);
                b += 1; //b++
            }
            while (b < 11);



        }

    }
}