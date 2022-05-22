// My notes from books and lectures.

using System;

namespace Notes_01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			
			int number;
            number = 10;
            double ak = 5.45;
            string s = "any text";
            char b = 'k';
            bool t = true;
            Console.WriteLine(number);
            Console.WriteLine(ak);
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(t);
			
			int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);
            Console.WriteLine(x + " + " + y + " = " + z);
            Console.WriteLine("{0} = {1} + {2}", z, y, x);
            Console.WriteLine($"{x} + {y} = {z}");
			
			// Two methods for converting a string to number
            int x = int.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y; // Operators: +, -, *, /, %
			// % operator - reminder of a division

            Console.WriteLine($"{x} + {y} = {z}");
			

      
        }
    }
}

		
		
		