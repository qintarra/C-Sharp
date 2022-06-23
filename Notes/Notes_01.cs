using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			
            //C# is a strongly typed language. Every variable and constant has a type.
            int number;
            number = 10;
            double ak = 5.45;
            string s = "any text";
            char r = 'k';
            bool t = true;
            Console.WriteLine(number);
            Console.WriteLine(ak);
            Console.WriteLine(s);
            Console.WriteLine(r);
            Console.WriteLine(t);
			
			
            //Three options for line output.
            int g = 10;
            int f = 20;
            int n = g + f;
            Console.WriteLine(g);
            Console.WriteLine(g + " + " + f + " = " + n);
            Console.WriteLine("{0} = {1} + {2}", n, f, g);
            Console.WriteLine($"{g} + {f} = {n}");
			
			
            // Two methods for converting a string to number.
            int i = int.Parse(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int h = i + e; // Operators: +, -, *, /, %
            // % operator - reminder of a division

            Console.WriteLine($"{i} + {e} = {h}");
			
			
            // Mathematical functions. Math class methods.
            double k = double.Parse(Console.ReadLine());
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sin({0}) = {1}",k,Math.Sin(k));
            Console.WriteLine("{0}^2 = {1}",l,Math.Pow(l, 2));
            Console.WriteLine("square root of {0} = {1}",k,Math.Sqrt(k));   
            Console.WriteLine("minimum = {0}",Math.Min(k,l));
            Console.WriteLine("maximum = {0}",Math.Max(k, l));
			
			
            //Conditional operator. Full form.
            int m = int.Parse(Console.ReadLine());

            if (m % 2 == 0)
            {
                Console.WriteLine($"Number {m} is even");
            }
            else
            {
                Console.WriteLine($"Number {m} is odd");
            }
			
      
            //Conditional operator.Short form.
            int p = int.Parse(Console.ReadLine());

            if (p % 2 == 0)
            {
                Console.WriteLine($"Number {p} is even");
            }

            if (p % 2 != 0)
            {
                Console.WriteLine($"Number {p} is odd");
            }


            //Including a conditional statement in a conditional statement. 
            //Program for solving a quadratic equation
            double a, b, c, d, x1, x2, x3;
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
                    x3 = -b / (2 * a);
                    Console.WriteLine($"x3 = {x3}");
                }
                else
                {
                    Console.WriteLine("No solutions");
                }
            }
        }
    }
}

		
		
		