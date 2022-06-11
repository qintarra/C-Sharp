using System;

namespace Notes_11.cs
{
    class Program
    {
        //11.1
        static void Sum(int a, in int b, ref int c, out int d)
        {
            Console.WriteLine($"The sum before change is {a + b + c}");

            // 'out' parameter must be assigned a value to the variable
            d = a + b + c;

            // 'ref' parameter can be changed and these changes are saved
            c = 100;

            // 'in' parameter can't be changed
            //b = 200;

            // 'value' parameter can be changed, but changes are not saved
            a = 300;

            Console.WriteLine($"The sum after change is {a + b + c}");
        }
		
        static void Main(string [] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;

            Sum(x, in y, ref z, out int s);

            Console.WriteLine($"The value of the first parameter {x}");
            Console.WriteLine($"The value of the second parameter {y}");
            Console.WriteLine($"The value of the third parameter {z}");
            Console.WriteLine($"The value of the fourth parameter {s}");
        }
		
        //11.2

       /* C# allows an optional parameters.
        * For such parameters you must declare a default value.
        * Also keep in min thet after an optional parameters
        * all subsequent parameters must also be optional
        */
    
        static int Sum(int x, int y, int z = 3, int s = 4)
        {
            return x + y + z + s;
        }
        static void Main(string [] args)
        {
            //Since the last two parameters are declared optional,
            //then we can omit one or both of them
            int sum1 = Sum(1, 2);
            Console.WriteLine(sum1);
            int sum2 = Sum(1, 2, 10);
            Console.WriteLine(sum2);
            int sum3 = Sum(10, 20, 30, 40);
            Console.WriteLine(sum3);
        }
    }
}