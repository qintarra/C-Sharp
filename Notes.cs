using System;

namespace Notes_01
// My notes from books and lectures.
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
			
	// Mathematical functions. Math class methods
            double x = double.Parse(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sin({0}) = {1}",x,Math.Sin(x));
            Console.WriteLine("{0}^2 = {1}",y,Math.Pow(y, 2));
            Console.WriteLine("square root of {0} = {1}",x,Math.Sqrt(x));   
            Console.WriteLine("minimum = {0}",Math.Min(x,y));
            Console.WriteLine("maximum = {0}",Math.Max(x, y));
			
		//Conditional operator full form

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine($"Number {x} is even");
            }
            else
            {
                Console.WriteLine($"Number {x} is odd");
            }
      
		//Conditional operator short form

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine($"Number {x} is even");
            }

            if (x % 2 != 0)
            {
                Console.WriteLine($"Number {x} is odd");
            }

	   double a, b, c, d, x1, x2, x;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1} x2 = {x2}");
            }
            else
            {
                if (d == 0)
                {
                    x = -b / (2 * a);
                    Console.WriteLine($"x = {x}");
                }
                else
                {
                    Console.WriteLine("No solutions");
                }
            }

        }
    }
}

		
		
		